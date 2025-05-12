namespace VideoOyunY
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOyunEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnOneri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(224, 275);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(121, 23);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOyunEkle
            // 
            this.btnOyunEkle.Location = new System.Drawing.Point(86, 50);
            this.btnOyunEkle.Name = "btnOyunEkle";
            this.btnOyunEkle.Size = new System.Drawing.Size(162, 56);
            this.btnOyunEkle.TabIndex = 4;
            this.btnOyunEkle.Text = "Oyun Ekle";
            this.btnOyunEkle.UseVisualStyleBackColor = true;
            this.btnOyunEkle.Click += new System.EventHandler(this.btnOyunEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(317, 50);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(162, 56);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Oyunları Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnOneri
            // 
            this.btnOneri.Location = new System.Drawing.Point(196, 161);
            this.btnOneri.Name = "btnOneri";
            this.btnOneri.Size = new System.Drawing.Size(162, 56);
            this.btnOneri.TabIndex = 7;
            this.btnOneri.Text = "Oyun Öneri";
            this.btnOneri.UseVisualStyleBackColor = true;
            this.btnOneri.Click += new System.EventHandler(this.btnOneri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(572, 354);
            this.Controls.Add(this.btnOneri);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnOyunEkle);
            this.Controls.Add(this.btnCikis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Detaylı Oyun | Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOyunEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnOneri;
    }
}

