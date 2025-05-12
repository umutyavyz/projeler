namespace EtkinlikBiletSistemi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnEtkinlikEkle;
        private System.Windows.Forms.ListBox lstEtkinlikler;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.ListBox lstBiletler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEtkinlikEkle = new System.Windows.Forms.Button();
            this.lstEtkinlikler = new System.Windows.Forms.ListBox();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.lstBiletler = new System.Windows.Forms.ListBox();
            this.txtEtkinlikAdi = new System.Windows.Forms.TextBox();
            this.dtpEtkinlikTarihi = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBiletSayisi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBiletFiyati = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEtkinlikEkle
            // 
            this.btnEtkinlikEkle.Location = new System.Drawing.Point(12, 134);
            this.btnEtkinlikEkle.Name = "btnEtkinlikEkle";
            this.btnEtkinlikEkle.Size = new System.Drawing.Size(104, 33);
            this.btnEtkinlikEkle.TabIndex = 2;
            this.btnEtkinlikEkle.Text = "Etkinlik Ekle";
            this.btnEtkinlikEkle.UseVisualStyleBackColor = true;
            this.btnEtkinlikEkle.Click += new System.EventHandler(this.btnEtkinlikEkle_Click);
            // 
            // lstEtkinlikler
            // 
            this.lstEtkinlikler.FormattingEnabled = true;
            this.lstEtkinlikler.ItemHeight = 16;
            this.lstEtkinlikler.Location = new System.Drawing.Point(12, 185);
            this.lstEtkinlikler.Name = "lstEtkinlikler";
            this.lstEtkinlikler.Size = new System.Drawing.Size(350, 148);
            this.lstEtkinlikler.TabIndex = 3;
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(12, 484);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(111, 41);
            this.btnBiletAl.TabIndex = 4;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // lstBiletler
            // 
            this.lstBiletler.FormattingEnabled = true;
            this.lstBiletler.ItemHeight = 16;
            this.lstBiletler.Location = new System.Drawing.Point(142, 441);
            this.lstBiletler.Name = "lstBiletler";
            this.lstBiletler.Size = new System.Drawing.Size(220, 84);
            this.lstBiletler.TabIndex = 5;
            // 
            // txtEtkinlikAdi
            // 
            this.txtEtkinlikAdi.Location = new System.Drawing.Point(100, 48);
            this.txtEtkinlikAdi.Name = "txtEtkinlikAdi";
            this.txtEtkinlikAdi.Size = new System.Drawing.Size(150, 22);
            this.txtEtkinlikAdi.TabIndex = 6;
            this.txtEtkinlikAdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpEtkinlikTarihi
            // 
            this.dtpEtkinlikTarihi.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpEtkinlikTarihi.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpEtkinlikTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEtkinlikTarihi.Location = new System.Drawing.Point(12, 17);
            this.dtpEtkinlikTarihi.MinDate = new System.DateTime(2025, 5, 12, 0, 0, 0, 0);
            this.dtpEtkinlikTarihi.Name = "dtpEtkinlikTarihi";
            this.dtpEtkinlikTarihi.Size = new System.Drawing.Size(146, 25);
            this.dtpEtkinlikTarihi.TabIndex = 7;
            this.dtpEtkinlikTarihi.Value = new System.DateTime(2025, 12, 25, 23, 59, 59, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Etkinlik Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBiletSayisi
            // 
            this.txtBiletSayisi.Location = new System.Drawing.Point(100, 76);
            this.txtBiletSayisi.MaxLength = 4;
            this.txtBiletSayisi.Name = "txtBiletSayisi";
            this.txtBiletSayisi.Size = new System.Drawing.Size(100, 22);
            this.txtBiletSayisi.TabIndex = 9;
            this.txtBiletSayisi.TextChanged += new System.EventHandler(this.txtBiletSayisi_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bilet Sayısı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bilet Fiyatı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBiletFiyati
            // 
            this.txtBiletFiyati.Location = new System.Drawing.Point(100, 106);
            this.txtBiletFiyati.MaxLength = 4;
            this.txtBiletFiyati.Name = "txtBiletFiyati";
            this.txtBiletFiyati.Size = new System.Drawing.Size(100, 22);
            this.txtBiletFiyati.TabIndex = 12;
            this.txtBiletFiyati.TextChanged += new System.EventHandler(this.txtBiletFiyati_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Etkinlik Tarihi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::etkinlikbiletsatiss.Properties.Resources.istanbul_konser_mekanlari;
            this.pictureBox1.Location = new System.Drawing.Point(-547, -116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1353, 765);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(771, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBiletFiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBiletSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEtkinlikTarihi);
            this.Controls.Add(this.txtEtkinlikAdi);
            this.Controls.Add(this.btnEtkinlikEkle);
            this.Controls.Add(this.lstEtkinlikler);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.lstBiletler);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Etkinlik ve Bilet Satış Sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtEtkinlikAdi;
        private System.Windows.Forms.DateTimePicker dtpEtkinlikTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBiletSayisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBiletFiyati;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
