﻿namespace SporTakip
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSporDali = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lstSporcular = new System.Windows.Forms.ListBox();
            this.btnAntrenmanEkle = new System.Windows.Forms.Button();
            this.btnTakipEkle = new System.Windows.Forms.Button();
            this.btnSporcuDetay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(591, 165);
            this.txtAd.MaxLength = 16;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            this.txtAd.Enter += new System.EventHandler(this.txtAd_Enter);
            this.txtAd.Leave += new System.EventHandler(this.txtAd_Leave);
            // 
            // txtSporDali
            // 
            this.txtSporDali.Location = new System.Drawing.Point(591, 204);
            this.txtSporDali.MaxLength = 32;
            this.txtSporDali.Name = "txtSporDali";
            this.txtSporDali.Size = new System.Drawing.Size(100, 20);
            this.txtSporDali.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(591, 243);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lstSporcular
            // 
            this.lstSporcular.BackColor = System.Drawing.SystemColors.Window;
            this.lstSporcular.FormattingEnabled = true;
            this.lstSporcular.Location = new System.Drawing.Point(103, 76);
            this.lstSporcular.Name = "lstSporcular";
            this.lstSporcular.Size = new System.Drawing.Size(149, 277);
            this.lstSporcular.TabIndex = 3;
            // 
            // btnAntrenmanEkle
            // 
            this.btnAntrenmanEkle.Location = new System.Drawing.Point(302, 164);
            this.btnAntrenmanEkle.Name = "btnAntrenmanEkle";
            this.btnAntrenmanEkle.Size = new System.Drawing.Size(100, 20);
            this.btnAntrenmanEkle.TabIndex = 4;
            this.btnAntrenmanEkle.Text = "Antrenman ekle";
            this.btnAntrenmanEkle.UseVisualStyleBackColor = true;
            this.btnAntrenmanEkle.Click += new System.EventHandler(this.btnAntrenmanEkle_Click);
            // 
            // btnTakipEkle
            // 
            this.btnTakipEkle.Location = new System.Drawing.Point(302, 203);
            this.btnTakipEkle.Name = "btnTakipEkle";
            this.btnTakipEkle.Size = new System.Drawing.Size(100, 20);
            this.btnTakipEkle.TabIndex = 5;
            this.btnTakipEkle.Text = "Takip ekle";
            this.btnTakipEkle.UseVisualStyleBackColor = true;
            this.btnTakipEkle.Click += new System.EventHandler(this.btnTakipEkle_Click);
            // 
            // btnSporcuDetay
            // 
            this.btnSporcuDetay.Location = new System.Drawing.Point(302, 247);
            this.btnSporcuDetay.Name = "btnSporcuDetay";
            this.btnSporcuDetay.Size = new System.Drawing.Size(100, 20);
            this.btnSporcuDetay.TabIndex = 6;
            this.btnSporcuDetay.Text = "Sporcu Detayı";
            this.btnSporcuDetay.UseVisualStyleBackColor = true;
            this.btnSporcuDetay.Click += new System.EventHandler(this.btnSporcuDetay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(523, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sporcu İsmi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(535, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Spor Dalı";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(103, 359);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 38);
            this.btnSil.TabIndex = 9;
            this.btnSil.Text = "Seçili Sporcuyu Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSporcuDetay);
            this.Controls.Add(this.btnTakipEkle);
            this.Controls.Add(this.btnAntrenmanEkle);
            this.Controls.Add(this.lstSporcular);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSporDali);
            this.Controls.Add(this.txtAd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Spor Istanbul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSporDali;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListBox lstSporcular;
        private System.Windows.Forms.Button btnAntrenmanEkle;
        private System.Windows.Forms.Button btnTakipEkle;
        private System.Windows.Forms.Button btnSporcuDetay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSil;
    }
}

