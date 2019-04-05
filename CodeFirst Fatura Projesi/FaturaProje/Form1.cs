using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaturaProje.Formlar;

namespace FaturaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteri frm = new FormMusteri();
            frm.Show();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIl frm = new FormIl();
            frm.Show();
        }

        private void ilçeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIlce frm = new FormIlce();
            frm.Show();
        }

        private void unvanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBirim frm = new FormBirim();
            frm.Show();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUrun frm = new FormUrun();
            frm.Show();
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeniFatura frm = new FormYeniFatura();
            frm.Show();
        }

        private void görüntüleSorgulaDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFaturaSorgulama frm = new FormFaturaSorgulama();
            frm.Show();
        }

    }
}
