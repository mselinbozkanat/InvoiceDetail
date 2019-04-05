using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaProje
{
    public partial class FormFaturaDetay : Form
    {
        public FormFaturaDetay()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        string urunadi;
        int id;
        public FormFaturaDetay(FaturaMaster fm)
        {
            InitializeComponent();
            faturaDoldur(fm);
            faturaDetayDoldur(fm.FaturaID);
            urunDoldur();
            id = fm.FaturaID;
        }

        private void urunDoldur()
        {
            var list = db.Urunler.ToList();
            cmbUrunAd.DisplayMember = "UrunAdi";
            cmbUrunAd.ValueMember = "UrunID";
            cmbUrunAd.DataSource = list;
        }

        private void faturaDetayDoldur(int id)
        {
            var list = db.FaturaDetays.Select(x => new
                {
                    x.FaturaID,
                    x.urun.UrunAdi,
                    x.urun.BirimFiyat,
                    x.Miktar,
                    x.ToplamFiyat,
                    x.KDV,
                    x.KDVliFiyat,
                    x.Aciklama
                }).Where(x => x.FaturaID == id).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[5].Width = 75;
            dataGridView1.Columns[7].Width = 350;
            lblFaturaToplam.Text = db.FaturaDetays.Where(x => x.FaturaID == id).Sum(x => x.KDVliFiyat).ToString();
        }

        private void faturaDoldur(FaturaMaster fm)
        {
            dtpFaturaTarihi.Value = fm.FaturaTarihi;
            datetimepickerOdemeTarihi.Value = fm.OdemeTarihi;
            txtIrsaliyeNo.Text = fm.IrsaliyeNo.ToString();
            txtMusteriSehir.Text = fm.musteri.ilce.il.Aciklama;
            txtMusteriIlce.Text = fm.musteri.ilce.Aciklama;
            txtMusteriAd.Text = fm.musteri.MusteriUnvani;
            lblFaturaID.Text = fm.FaturaID.ToString();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            decimal fiyat = db.Urunler.Find((int)cmbUrunAd.SelectedValue).BirimFiyat;
            FaturaDetay fd = new FaturaDetay();
            fd.FaturaID = Convert.ToInt32(lblFaturaID.Text);
            fd.UrunID = (int)cmbUrunAd.SelectedValue;
            fd.Miktar = (decimal)numMiktar.Value;
            fd.KDV = Convert.ToDecimal("0,18");
            fd.ToplamFiyat = fd.Miktar * fiyat;
            fd.KDVliFiyat = fd.ToplamFiyat + fd.ToplamFiyat * fd.KDV;
            fd.FaturaToplam += fd.KDVliFiyat;
            db.FaturaDetays.Add(fd);
            db.SaveChanges();
            faturaDetayDoldur(fd.FaturaID);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            FaturaDetay fd = db.FaturaDetays.Where(x => x.FaturaID == id && x.urun.UrunAdi == urunadi).FirstOrDefault();
            db.FaturaDetays.Remove(fd);
            db.SaveChanges();
            faturaDetayDoldur(id);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            urunadi = dataGridView1.CurrentRow.Cells["UrunAdi"].Value.ToString();
        }

    }
}
