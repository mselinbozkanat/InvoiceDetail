using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaProje
{
    public partial class FormYeniFatura : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenID;
        List<UrunSecilen> urunlistesi = new List<UrunSecilen>();
        public FormYeniFatura()
        {
            InitializeComponent();
        }

        private void FormYeniFatura_Load(object sender, EventArgs e)
        {
            MusteriSehirDoldur();
            UrunDoldur();
        }

        private void MusteriSehirDoldur()
        {
            var list = db.Iller.ToList();
            cmbMusteriSehir.DisplayMember = "Aciklama";
            cmbMusteriSehir.ValueMember = "IlID";
            cmbMusteriSehir.DataSource = list;
        }
        private void IlceDoldur()
        {
            var list = db.Ilceler.Where(x => x.IlID == (int)cmbMusteriSehir.SelectedValue).ToList();
            cmbMusteriIlce.DisplayMember = "Aciklama";
            cmbMusteriIlce.ValueMember = "IlceID";
            cmbMusteriIlce.DataSource = list;
        }
        private void MusteriDoldur()
        {
            var mlist = db.Musteriler.Select(x => new
            {
                x.IlceID,
                x.MusteriID,
                x.MusteriUnvani
            }).Where(x => x.IlceID == (int)cmbMusteriIlce.SelectedValue).OrderBy(x => x.MusteriUnvani).ToList();
            if (mlist.Count != 0)
            {
                cmbMusteri.DisplayMember = "MusteriUnvani";
                cmbMusteri.ValueMember = "MusteriID";
                cmbMusteri.DataSource = mlist;
            }
            else
            {
                cmbMusteri.DataSource = null;
            }

        }
        private void UrunDoldur()
        {
            var ulist = db.Urunler.Select(x => new
            {
                x.UrunID,
                x.UrunAdi
            }).OrderBy(x => x.UrunAdi).ToList();
            comboUrunAd.DisplayMember = "UrunAdi";
            comboUrunAd.ValueMember = "UrunID";
            comboUrunAd.DataSource = ulist;
        }
        private void Listele()
        {
            dataGridView1.DataSource = urunlistesi.Select(x => new
            {
                x.UrunID,
                x.UrunAdi,
                x.UrunFiyat,
                x.Miktar,
                x.KDV,
                x.ToplamTutar,
                GenelToplam = x.ToplamTutar + x.ToplamTutar * x.KDV
            }).ToList();
            dataGridView1.Columns[0].Visible = false;
            Temizle();
            FaturaToplam();
        }
        private void Temizle()
        {
            numericMiktar.Value = 0;
        }

        private void FaturaToplam()
        {
            decimal toplam = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                toplam += Convert.ToDecimal(dataGridView1[6, i].Value);
            }
            lblfaturatoplam.Text = Convert.ToString(String.Format("{0:0.00}", toplam + "TL"));
            toplam = Math.Round(toplam, 2);

        }
        private void cmbMusteriSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceDoldur();
        }
        private void cmbMusteriIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriDoldur();
        }
        private void comboUrunAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal fiyat = db.Urunler.Find((int)comboUrunAd.SelectedValue).BirimFiyat;
            txtUrunFiyat.Text = fiyat.ToString();
            string birim = db.Urunler.Find((int)comboUrunAd.SelectedValue).birim.BirimAd;
            txtUrunBirim.Text = birim;
            txtUrunKDV.Text = "0,18";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            var urun = urunlistesi.Where(x => x.UrunID == secilenID).FirstOrDefault();
            comboUrunAd.SelectedValue = secilenID;
            numericMiktar.Value = urun.Miktar;
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunlistesi.Add(new UrunSecilen
            {
                UrunID = (int)comboUrunAd.SelectedValue,
                UrunAdi = comboUrunAd.Text,
                UrunFiyat = Convert.ToDecimal(txtUrunFiyat.Text),
                KDV = Convert.ToDecimal(txtUrunKDV.Text),
                Miktar = (decimal)numericMiktar.Value,
                ToplamTutar = Convert.ToDecimal(txtUrunFiyat.Text) * (decimal)numericMiktar.Value
            });
            Listele();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = urunlistesi.Where(x => x.UrunID == secilenID).FirstOrDefault();
                if (secilenID == (int)comboUrunAd.SelectedValue)
                {
                    urun.Miktar = (decimal)numericMiktar.Value;
                    urun.ToplamTutar = Convert.ToDecimal(txtUrunFiyat.Text) * (decimal)numericMiktar.Value;
                }
                else
                {
                    urun.UrunID = (int)comboUrunAd.SelectedValue;
                    urun.UrunAdi = comboUrunAd.Text;
                    urun.UrunFiyat = Convert.ToDecimal(txtUrunFiyat.Text);
                    urun.Miktar = (decimal)numericMiktar.Value;
                    urun.ToplamTutar = Convert.ToDecimal(txtUrunFiyat.Text) * (decimal)numericMiktar.Value;
                }
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden ürün seçiniz..");
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                var urun = urunlistesi.Where(x => x.UrunID == secilenID).FirstOrDefault();
                urunlistesi.Remove(urun);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen listeden ürün seçiniz..");
            }

        }

        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            DbContextTransaction tran = db.Database.BeginTransaction();
            try
            {
                FaturaKaydet();
                FaturaDetayKaydet();
                tran.Commit();
            }
            catch (Exception)
            {
                tran.Rollback();
                MessageBox.Show("Beklenmeyen bir hata oluştu..");
            }

        }
        private void FaturaKaydet()
        {

            FaturaMaster fm = new FaturaMaster();
            fm.IrsaliyeNo = Convert.ToInt32(txtIrsaliyeNo.Text);
            fm.OdemeTarihi = datetimepickerOdemeTarihi.Value;
            fm.MusteriID = (int)cmbMusteri.SelectedValue;
            db.FaturaMasters.Add(fm);
            db.SaveChanges();
            lblFaturaID.Text = fm.FaturaID.ToString();
        }
        private void FaturaDetayKaydet()
        {
            foreach (UrunSecilen item in urunlistesi)
            {
                FaturaDetay fd = new FaturaDetay();
                fd.FaturaID = Convert.ToInt32(lblFaturaID.Text);
                fd.UrunID = item.UrunID;
                fd.Miktar = item.Miktar;
                fd.KDV = item.KDV;
                fd.ToplamFiyat = item.Miktar * item.UrunFiyat;
                fd.KDVliFiyat = fd.ToplamFiyat + fd.ToplamFiyat * fd.KDV;
                fd.FaturaToplam = Convert.ToDecimal(lblfaturatoplam.Text.Substring(0,lblfaturatoplam.Text.Length-2));
                db.FaturaDetays.Add(fd);
            }
            db.SaveChanges();
            MessageBox.Show("Ürünler başarılı bir şekilde faturaya eklendi.\nFatura kayıt edildi");

        }

        private void btnListeTemizle_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            urunlistesi.Clear();
        }
    }
}
