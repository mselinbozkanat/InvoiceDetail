using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaturaProje.Formlar
{
    public partial class FormBirim : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenID;
        public FormBirim()
        {
            InitializeComponent();
        }

        private void FormBirim_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            var list = db.Birimler.Select(x => new
            {
                BirimKodu = x.BirimID,
                x.BirimAd
                
            }).ToList();
            dataGridView1.DataSource = list;
            txtBirimAdi.Clear();
            txtBirimAdi.Focus();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = new Birim();
                birim.BirimAd = txtBirimAdi.Text;
                db.Birimler.Add(birim);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen ürün adı giriniz.");
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = db.Birimler.Find(secilenID);
                birim.BirimAd = txtBirimAdi.Text;
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir birim seçiniz..");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birin = db.Birimler.Find(secilenID);
                db.Birimler.Remove(birin);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir birim seçiniz..");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Birim birim = db.Birimler.Find(secilenID);
            txtBirimAdi.Text = birim.BirimAd;
        }
    }
}
