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
    public partial class FormMusteri : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenID;
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void FormMusteri_Load(object sender, EventArgs e)
        {
            ilDoldur();
            Listele();
        }

        private void ilDoldur()
        {
            var list = db.Iller.Select(x => new
            {
                x.IlID,
                x.Aciklama

            }).OrderBy(x=> x.Aciklama).ToList();
            comboMusteriSehri.DisplayMember = "Aciklama";
            comboMusteriSehri.ValueMember = "IlID";
            comboMusteriSehri.DataSource = list;
        }

        private void ilceDoldur()
        {
            var list = db.Ilceler.Select(x => new
            {
                x.IlID,
                x.IlceID,
                x.Aciklama

            }).OrderBy(x => x.Aciklama).Where(x => x.IlID == (int)comboMusteriSehri.SelectedValue).ToList();
            comboMusteriilce.DisplayMember = "Aciklama";
            comboMusteriilce.ValueMember = "IlceID";
            comboMusteriilce.DataSource = list;
        }

        private void Listele()
        {
            var mlist = db.Musteriler.Select(x => new
            {
                MusteriKodu = x.MusteriID,
                x.MusteriUnvani,
                SehirAdi = x.ilce.il.Aciklama,
                IlceAdi = x.ilce.Aciklama,
                x.MusteriAdresi

            }).ToList();
            dataGridView1.DataSource = mlist;

            txtMusteriAdres.Clear();
            txtMusteriUnvan.Clear();
            txtMusteriUnvan.Focus();
        }

        private void comboMusteriSehri_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilceDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriUnvani = txtMusteriUnvan.Text;
            musteri.MusteriAdresi = txtMusteriAdres.Text;
            musteri.IlceID = (int)comboMusteriilce.SelectedValue;
            db.Musteriler.Add(musteri);
            db.SaveChanges();
            Listele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = db.Musteriler.Find(secilenID);
                musteri.MusteriUnvani = txtMusteriUnvan.Text;
                musteri.MusteriAdresi = txtMusteriAdres.Text;
                musteri.IlceID = (int)comboMusteriilce.SelectedValue;
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = db.Musteriler.Find(secilenID);
                db.Musteriler.Remove(musteri);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz");
            }
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenID = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Musteri musteri = db.Musteriler.Find(secilenID);
                txtMusteriUnvan.Text = musteri.MusteriUnvani;
                txtMusteriAdres.Text = musteri.MusteriAdresi;
                comboMusteriSehri.SelectedValue = musteri.ilce.IlID;
                comboMusteriilce.SelectedValue = musteri.IlceID;
            }
            catch
            {

            }
        }
    }
}
