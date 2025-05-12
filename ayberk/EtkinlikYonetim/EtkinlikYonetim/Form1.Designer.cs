namespace EtkinlikYonetim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEtkinlikEkle = new System.Windows.Forms.Button();
            this.txtEtkinlikAd = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.numKapasite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKatilimciEkle = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEtkinlikEkle
            // 
            this.btnEtkinlikEkle.Location = new System.Drawing.Point(46, 116);
            this.btnEtkinlikEkle.Name = "btnEtkinlikEkle";
            this.btnEtkinlikEkle.Size = new System.Drawing.Size(124, 36);
            this.btnEtkinlikEkle.TabIndex = 0;
            this.btnEtkinlikEkle.Text = "Etkinlik Ekle";
            this.btnEtkinlikEkle.UseVisualStyleBackColor = true;
            this.btnEtkinlikEkle.Click += new System.EventHandler(this.btnEtkinlikEkle_Click);
            // 
            // txtEtkinlikAd
            // 
            this.txtEtkinlikAd.Location = new System.Drawing.Point(108, 72);
            this.txtEtkinlikAd.MaxLength = 80;
            this.txtEtkinlikAd.Name = "txtEtkinlikAd";
            this.txtEtkinlikAd.Size = new System.Drawing.Size(127, 20);
            this.txtEtkinlikAd.TabIndex = 1;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(46, 46);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(189, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // numKapasite
            // 
            this.numKapasite.Location = new System.Drawing.Point(322, 46);
            this.numKapasite.Name = "numKapasite";
            this.numKapasite.Size = new System.Drawing.Size(49, 20);
            this.numKapasite.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Etkinlik Adı";
            // 
            // btnKatilimciEkle
            // 
            this.btnKatilimciEkle.Location = new System.Drawing.Point(208, 116);
            this.btnKatilimciEkle.Name = "btnKatilimciEkle";
            this.btnKatilimciEkle.Size = new System.Drawing.Size(124, 36);
            this.btnKatilimciEkle.TabIndex = 5;
            this.btnKatilimciEkle.Text = "Katılımcı Ekleme";
            this.btnKatilimciEkle.UseVisualStyleBackColor = true;
            this.btnKatilimciEkle.Click += new System.EventHandler(this.btnKatilimciEkle_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(365, 116);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(124, 36);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Bilet Oluştur";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Giris Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kişi Kapasitesi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Katılımcı Görüntüle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(516, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnKatilimciEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numKapasite);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtEtkinlikAd);
            this.Controls.Add(this.btnEtkinlikEkle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BuBilet";
            ((System.ComponentModel.ISupportInitialize)(this.numKapasite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEtkinlikEkle;
        private System.Windows.Forms.TextBox txtEtkinlikAd;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown numKapasite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKatilimciEkle;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

