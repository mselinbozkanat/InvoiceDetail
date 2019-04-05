namespace FaturaProje
{
    partial class FormYeniFatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYeniFatura));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimepickerOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUrunKDV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtUrunBirim = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtUrunFiyat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericMiktar = new System.Windows.Forms.NumericUpDown();
            this.comboUrunAd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblFaturaID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMusteriIlce = new System.Windows.Forms.ComboBox();
            this.cmbMusteriSehir = new System.Windows.Forms.ComboBox();
            this.btnFaturaKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblfaturatoplam = new System.Windows.Forms.Label();
            this.btnListeTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 226);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(90, 98);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(140, 21);
            this.cmbMusteri.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Müşteri";
            // 
            // txtIrsaliyeNo
            // 
            this.txtIrsaliyeNo.Location = new System.Drawing.Point(90, 125);
            this.txtIrsaliyeNo.Name = "txtIrsaliyeNo";
            this.txtIrsaliyeNo.Size = new System.Drawing.Size(140, 20);
            this.txtIrsaliyeNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "İrsaliye No";
            // 
            // datetimepickerOdemeTarihi
            // 
            this.datetimepickerOdemeTarihi.CustomFormat = "dd/MM/yyyy";
            this.datetimepickerOdemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepickerOdemeTarihi.Location = new System.Drawing.Point(90, 152);
            this.datetimepickerOdemeTarihi.Name = "datetimepickerOdemeTarihi";
            this.datetimepickerOdemeTarihi.Size = new System.Drawing.Size(140, 20);
            this.datetimepickerOdemeTarihi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ödeme Tarihi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUrunKDV);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.txtUrunBirim);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtUrunFiyat);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericMiktar);
            this.groupBox1.Controls.Add(this.comboUrunAd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(269, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün İşlemleri";
            // 
            // txtUrunKDV
            // 
            this.txtUrunKDV.Location = new System.Drawing.Point(96, 95);
            this.txtUrunKDV.Name = "txtUrunKDV";
            this.txtUrunKDV.ReadOnly = true;
            this.txtUrunKDV.Size = new System.Drawing.Size(170, 20);
            this.txtUrunKDV.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Ürün KDV";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(185, 150);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(82, 28);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Ürün Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtUrunBirim
            // 
            this.txtUrunBirim.Location = new System.Drawing.Point(96, 68);
            this.txtUrunBirim.Name = "txtUrunBirim";
            this.txtUrunBirim.ReadOnly = true;
            this.txtUrunBirim.Size = new System.Drawing.Size(170, 20);
            this.txtUrunBirim.TabIndex = 12;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(94, 152);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(84, 27);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Ürün Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(9, 152);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(79, 27);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtUrunFiyat
            // 
            this.txtUrunFiyat.Location = new System.Drawing.Point(96, 42);
            this.txtUrunFiyat.Name = "txtUrunFiyat";
            this.txtUrunFiyat.ReadOnly = true;
            this.txtUrunFiyat.Size = new System.Drawing.Size(170, 20);
            this.txtUrunFiyat.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Ürün Fiyatı";
            // 
            // numericMiktar
            // 
            this.numericMiktar.Location = new System.Drawing.Point(97, 120);
            this.numericMiktar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericMiktar.Name = "numericMiktar";
            this.numericMiktar.Size = new System.Drawing.Size(170, 20);
            this.numericMiktar.TabIndex = 8;
            // 
            // comboUrunAd
            // 
            this.comboUrunAd.FormattingEnabled = true;
            this.comboUrunAd.Location = new System.Drawing.Point(96, 15);
            this.comboUrunAd.Name = "comboUrunAd";
            this.comboUrunAd.Size = new System.Drawing.Size(171, 21);
            this.comboUrunAd.TabIndex = 6;
            this.comboUrunAd.SelectedIndexChanged += new System.EventHandler(this.comboUrunAd_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ürün Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Birimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblFaturaID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbMusteriIlce);
            this.groupBox2.Controls.Add(this.cmbMusteriSehir);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cmbMusteri);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIrsaliyeNo);
            this.groupBox2.Controls.Add(this.datetimepickerOdemeTarihi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 187);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri ve İrsaliye";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Fatura No";
            // 
            // lblFaturaID
            // 
            this.lblFaturaID.AutoSize = true;
            this.lblFaturaID.Location = new System.Drawing.Point(87, 21);
            this.lblFaturaID.Name = "lblFaturaID";
            this.lblFaturaID.Size = new System.Drawing.Size(0, 13);
            this.lblFaturaID.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Müşteri İlçesi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Müşteri Şehri";
            // 
            // cmbMusteriIlce
            // 
            this.cmbMusteriIlce.FormattingEnabled = true;
            this.cmbMusteriIlce.Location = new System.Drawing.Point(90, 72);
            this.cmbMusteriIlce.Name = "cmbMusteriIlce";
            this.cmbMusteriIlce.Size = new System.Drawing.Size(140, 21);
            this.cmbMusteriIlce.TabIndex = 8;
            this.cmbMusteriIlce.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriIlce_SelectedIndexChanged);
            // 
            // cmbMusteriSehir
            // 
            this.cmbMusteriSehir.FormattingEnabled = true;
            this.cmbMusteriSehir.Location = new System.Drawing.Point(90, 44);
            this.cmbMusteriSehir.Name = "cmbMusteriSehir";
            this.cmbMusteriSehir.Size = new System.Drawing.Size(140, 21);
            this.cmbMusteriSehir.TabIndex = 7;
            this.cmbMusteriSehir.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriSehir_SelectedIndexChanged);
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.BackColor = System.Drawing.Color.White;
            this.btnFaturaKaydet.Location = new System.Drawing.Point(553, 38);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(91, 55);
            this.btnFaturaKaydet.TabIndex = 14;
            this.btnFaturaKaydet.Text = "Fatura\r\nKaydet\r\n";
            this.btnFaturaKaydet.UseVisualStyleBackColor = false;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(460, 443);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Fatura Toplamı =";
            // 
            // lblfaturatoplam
            // 
            this.lblfaturatoplam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblfaturatoplam.AutoSize = true;
            this.lblfaturatoplam.Location = new System.Drawing.Point(568, 443);
            this.lblfaturatoplam.Name = "lblfaturatoplam";
            this.lblfaturatoplam.Size = new System.Drawing.Size(0, 13);
            this.lblfaturatoplam.TabIndex = 15;
            // 
            // btnListeTemizle
            // 
            this.btnListeTemizle.BackColor = System.Drawing.Color.White;
            this.btnListeTemizle.Location = new System.Drawing.Point(553, 107);
            this.btnListeTemizle.Name = "btnListeTemizle";
            this.btnListeTemizle.Size = new System.Drawing.Size(91, 55);
            this.btnListeTemizle.TabIndex = 17;
            this.btnListeTemizle.Text = "Liste\r\nTemizle\r\n";
            this.btnListeTemizle.UseVisualStyleBackColor = false;
            this.btnListeTemizle.Click += new System.EventHandler(this.btnListeTemizle_Click);
            // 
            // FormYeniFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 465);
            this.Controls.Add(this.btnListeTemizle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblfaturatoplam);
            this.Controls.Add(this.btnFaturaKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormYeniFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Fatura İşlemleri";
            this.Load += new System.EventHandler(this.FormYeniFatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMiktar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIrsaliyeNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepickerOdemeTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericMiktar;
        private System.Windows.Forms.ComboBox comboUrunAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMusteriIlce;
        private System.Windows.Forms.ComboBox cmbMusteriSehir;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtUrunBirim;
        private System.Windows.Forms.TextBox txtUrunFiyat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFaturaKaydet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblFaturaID;
        private System.Windows.Forms.TextBox txtUrunKDV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblfaturatoplam;
        private System.Windows.Forms.Button btnListeTemizle;
    }
}