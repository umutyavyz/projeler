namespace SaglikTakip
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
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.btnSaglikKaydi = new System.Windows.Forms.Button();
            this.btnEgzersizEkle = new System.Windows.Forms.Button();
            this.Raporgor = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Location = new System.Drawing.Point(70, 63);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(116, 57);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // btnSaglikKaydi
            // 
            this.btnSaglikKaydi.Location = new System.Drawing.Point(237, 63);
            this.btnSaglikKaydi.Name = "btnSaglikKaydi";
            this.btnSaglikKaydi.Size = new System.Drawing.Size(116, 57);
            this.btnSaglikKaydi.TabIndex = 1;
            this.btnSaglikKaydi.Text = "Sağlık Kaydı Ekle";
            this.btnSaglikKaydi.UseVisualStyleBackColor = true;
            this.btnSaglikKaydi.Click += new System.EventHandler(this.btnSaglikKaydi_Click);
            // 
            // btnEgzersizEkle
            // 
            this.btnEgzersizEkle.Location = new System.Drawing.Point(237, 145);
            this.btnEgzersizEkle.Name = "btnEgzersizEkle";
            this.btnEgzersizEkle.Size = new System.Drawing.Size(116, 57);
            this.btnEgzersizEkle.TabIndex = 2;
            this.btnEgzersizEkle.Text = "Egzersiz Planla";
            this.btnEgzersizEkle.UseVisualStyleBackColor = true;
            this.btnEgzersizEkle.Click += new System.EventHandler(this.btnEgzersizEkle_Click);
            // 
            // Raporgor
            // 
            this.Raporgor.Location = new System.Drawing.Point(70, 145);
            this.Raporgor.Name = "Raporgor";
            this.Raporgor.Size = new System.Drawing.Size(116, 57);
            this.Raporgor.TabIndex = 3;
            this.Raporgor.Text = "Rapor Görüntüle";
            this.Raporgor.UseVisualStyleBackColor = true;
            this.Raporgor.Click += new System.EventHandler(this.Raporgor_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(172, 240);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 23);
            this.cikis.TabIndex = 4;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(419, 301);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.Raporgor);
            this.Controls.Add(this.btnEgzersizEkle);
            this.Controls.Add(this.btnSaglikKaydi);
            this.Controls.Add(this.btnKullaniciEkle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Saglik Gov TR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.Button btnSaglikKaydi;
        private System.Windows.Forms.Button btnEgzersizEkle;
        private System.Windows.Forms.Button Raporgor;
        private System.Windows.Forms.Button cikis;
    }
}

