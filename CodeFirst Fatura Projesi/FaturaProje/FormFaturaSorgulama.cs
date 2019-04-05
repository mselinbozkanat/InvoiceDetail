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
    public partial class FormFaturaSorgulama : Form
    {
        public FormFaturaSorgulama()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        private void FormFaturaSorgulama_Load(object sender, EventArgs e)
        {
            MusteriSehirDoldur();
            Listele();
        }
        void MusteriSehirDoldur()
        {
            var list = db.Iller.ToList();
            cmbSehir.DisplayMember = "Aciklama";
            cmbSehir.ValueMember = "IlID";
            cmbSehir.DataSource = list;

        }
        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriIlceDoldur();
        }
        private void MusteriIlceDoldur()
        {
            var list = db.Ilceler.Where(x => x.IlID == (int)cmbSehir.SelectedValue).ToList();
            cmbilce.DisplayMember = "Aciklama";
            cmbilce.ValueMember = "IlceID";
            cmbilce.DataSource = list;
        }
        private void cmbilce_SelectedIndexChanged(object sender, EventArgs e)
        {
            MusteriDoldur();
        }

        private void MusteriDoldur()
        {
            var list = db.Musteriler.Where(x => x.IlceID == (int)cmbilce.SelectedValue).ToList();
            cmbMusteri.DisplayMember = "MusteriUnvani";
            cmbMusteri.ValueMember = "MusteriID";
            cmbMusteri.DataSource = list;
        }

        private void Listele()
        {
            dataGridView1.DataSource = db.FaturaMasters.Select(x => new
            {
                x.FaturaID,
                x.MusteriID,
                x.musteri.MusteriUnvani,
                Sehir = x.musteri.ilce.il.Aciklama,
                İlçe = x.musteri.ilce.Aciklama,
                x.FaturaTarihi,
                x.OdemeTarihi,
                x.IrsaliyeNo
            }).Where(x => x.FaturaID.ToString().Contains(txtFaturaNo.Text)).ToList();
            dataGridView1.Columns[0].Width = 75;
            dataGridView1.Columns[1].Width = 75;
            dataGridView1.Columns[7].Width = 60;
        }
        private void txtFaturaNo_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.FaturaMasters.Select(x => new
            {
                x.FaturaID,
                x.MusteriID,
                x.musteri.MusteriUnvani,
                Sehir = x.musteri.ilce.il.Aciklama,
                İlçe = x.musteri.ilce.Aciklama,
                x.FaturaTarihi,
                x.OdemeTarihi,
                x.IrsaliyeNo
            }).Where(x => x.MusteriID == (int)cmbMusteri.SelectedValue).ToList();
        }



        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int secilenid = (int)dataGridView1.CurrentRow.Cells[0].Value;
            FaturaMaster fm = db.FaturaMasters.Find(secilenid);
            if (fm != null)
            {
                FormFaturaDetay frm = new FormFaturaDetay(fm);
                frm.Show();
            }
            else MessageBox.Show("Böyle bir fatura detayı yok.");
        }

        private void btnTumSiparis_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.FaturaMasters.Select(x => new
            {
                x.FaturaID,
                x.MusteriID,
                x.musteri.MusteriUnvani,
                Sehir = x.musteri.ilce.il.Aciklama,
                İlçe = x.musteri.ilce.Aciklama,
                x.FaturaTarihi,
                x.OdemeTarihi,
                x.IrsaliyeNo
            }).OrderBy(x => x.FaturaID).ToList();

        }


    }
}
