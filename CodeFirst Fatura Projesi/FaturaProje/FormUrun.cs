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
    public partial class FormUrun : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenID;
        public FormUrun()
        {
            InitializeComponent();
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            BirimListele();
            Listele();

        }

        private void BirimListele()
        {
            var blist = db.Birimler.Select(x => new
            {
                x.BirimID,
                x.BirimAd
            }).OrderBy(x=> x.BirimAd).ToList();
            comboBirimAd.DisplayMember = "BirimAd";
            comboBirimAd.ValueMember = "BirimID";
            comboBirimAd.DataSource = blist;
        }
        private void Listele()
        {
            var list = db.Urunler.Select(x => new
            {
                x.UrunID,
                x.UrunKodu,
                x.UrunAdi,
                Birimi = x.birim.BirimAd,
                x.BirimFiyat

            }).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].Visible = false;

            txtUrunAd.Clear();
            txtUrunAd.Focus();
            txtUrunKodu.Clear();
            txtBirimFiyat.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun();
                urun.UrunAdi = txtUrunAd.Text;
                urun.UrunKodu = txtUrunKodu.Text;
                urun.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
                urun.BirimID = (int)comboBirimAd.SelectedValue;
                db.Urunler.Add(urun);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = db.Urunler.Find(secilenID);
                urun.UrunAdi = txtUrunAd.Text;
                urun.UrunKodu = txtUrunKodu.Text;
                urun.BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
                urun.BirimID = (int)comboBirimAd.SelectedValue;
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz..");
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = db.Urunler.Find(secilenID);
                db.Urunler.Remove(urun);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz..");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenID = (int)dataGridView1.CurrentRow.Cells["UrunID"].Value;
                Urun urun = db.Urunler.Find(secilenID);
                txtUrunAd.Text = urun.UrunAdi;
                txtUrunKodu.Text = urun.UrunKodu;
                txtBirimFiyat.Text = urun.BirimFiyat.ToString();
                comboBirimAd.SelectedValue = urun.birim.BirimID;
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }
}
