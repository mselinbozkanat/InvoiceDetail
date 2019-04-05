namespace FaturaProje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tanımlamalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unvanEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.görüntüleSorgulaDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlamalarToolStripMenuItem,
            this.faturaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tanımlamalarToolStripMenuItem
            // 
            this.tanımlamalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriEkleToolStripMenuItem,
            this.unvanEkleToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.ilEkleToolStripMenuItem,
            this.ilçeEkleToolStripMenuItem});
            this.tanımlamalarToolStripMenuItem.Name = "tanımlamalarToolStripMenuItem";
            this.tanımlamalarToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.tanımlamalarToolStripMenuItem.Text = "Tanımlamalar";
            // 
            // musteriEkleToolStripMenuItem
            // 
            this.musteriEkleToolStripMenuItem.Name = "musteriEkleToolStripMenuItem";
            this.musteriEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.musteriEkleToolStripMenuItem.Text = "Musteri Ekle";
            this.musteriEkleToolStripMenuItem.Click += new System.EventHandler(this.musteriEkleToolStripMenuItem_Click);
            // 
            // unvanEkleToolStripMenuItem
            // 
            this.unvanEkleToolStripMenuItem.Name = "unvanEkleToolStripMenuItem";
            this.unvanEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.unvanEkleToolStripMenuItem.Text = "Birim Ekle";
            this.unvanEkleToolStripMenuItem.Click += new System.EventHandler(this.unvanEkleToolStripMenuItem_Click);
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.urunEkleToolStripMenuItem.Text = "Urun Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // ilEkleToolStripMenuItem
            // 
            this.ilEkleToolStripMenuItem.Name = "ilEkleToolStripMenuItem";
            this.ilEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ilEkleToolStripMenuItem.Text = "İl Ekle";
            this.ilEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilçeEkleToolStripMenuItem
            // 
            this.ilçeEkleToolStripMenuItem.Name = "ilçeEkleToolStripMenuItem";
            this.ilçeEkleToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ilçeEkleToolStripMenuItem.Text = "İlçe Ekle";
            this.ilçeEkleToolStripMenuItem.Click += new System.EventHandler(this.ilçeEkleToolStripMenuItem_Click);
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görüntüleSorgulaDüzenleToolStripMenuItem,
            this.yeniFaturaToolStripMenuItem});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // görüntüleSorgulaDüzenleToolStripMenuItem
            // 
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Name = "görüntüleSorgulaDüzenleToolStripMenuItem";
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Text = "Görüntüle / Sorgula / Düzenle";
            this.görüntüleSorgulaDüzenleToolStripMenuItem.Click += new System.EventHandler(this.görüntüleSorgulaDüzenleToolStripMenuItem_Click);
            // 
            // yeniFaturaToolStripMenuItem
            // 
            this.yeniFaturaToolStripMenuItem.Name = "yeniFaturaToolStripMenuItem";
            this.yeniFaturaToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.yeniFaturaToolStripMenuItem.Text = "Yeni Fatura Oluştur";
            this.yeniFaturaToolStripMenuItem.Click += new System.EventHandler(this.yeniFaturaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 336);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tanımlamalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unvanEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem görüntüleSorgulaDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaToolStripMenuItem;
    }
}

