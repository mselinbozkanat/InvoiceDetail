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
    public partial class FormIlce : Form
    {
        FaturaContext db = new FaturaContext();
        int secilenid;

        public FormIlce()
        {
            InitializeComponent();
        }

        private void FormIlce_Load(object sender, EventArgs e)
        {
            ComboListele();
            Listele();
        }

        private void Listele()
        {
            try
            {
                var list = db.Ilceler.Select(x => new
                {
                    x.IlID,
                    SehirAdi = x.il.Aciklama,
                    x.IlceID,
                    İlceAdi = x.Aciklama
                }).Where(x => x.IlID == (int)cmbBoxIl.SelectedValue).OrderBy(x => x.SehirAdi).ToList();
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;

                txtBoxIlce.Clear();
                txtBoxIlce.Focus();
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void ComboListele()
        {
            var list = db.Iller.Select(x => new
            {
                x.IlID,
                x.Aciklama
            }).OrderBy(x => x.Aciklama).ToList();

            cmbBoxIl.DisplayMember = "Aciklama";
            cmbBoxIl.ValueMember = "IlID";
            cmbBoxIl.DataSource = list;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = new Ilce();
                ilce.Aciklama = txtBoxIlce.Text;
                ilce.IlID = Convert.ToInt32(cmbBoxIl.SelectedValue);
                db.Ilceler.Add(ilce);
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
                Ilce ilce = db.Ilceler.Find(secilenid);
                ilce.Aciklama = txtBoxIlce.Text;
                ilce.IlID = Convert.ToInt32(cmbBoxIl.SelectedValue);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir ilçe seçiniz");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                secilenid = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                Ilce ilce = db.Ilceler.Find(secilenid);
                txtBoxIlce.Text = ilce.Aciklama;
                cmbBoxIl.SelectedValue = ilce.il.IlID;
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = db.Ilceler.Find(secilenid);
                db.Ilceler.Remove(ilce);
                db.SaveChanges();
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen bir ilçe seçiniz");
            }
        }

        private void cmbBoxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
