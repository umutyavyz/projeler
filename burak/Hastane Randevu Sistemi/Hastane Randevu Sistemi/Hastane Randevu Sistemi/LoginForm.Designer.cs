﻿namespace Hastane_Randevu_Sistemi
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.buttonUyeOl = new System.Windows.Forms.Button();
            this.buttonGiris = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.buttonDoktorGiris = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUyeOl
            // 
            this.buttonUyeOl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonUyeOl.Location = new System.Drawing.Point(41, 292);
            this.buttonUyeOl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUyeOl.Name = "buttonUyeOl";
            this.buttonUyeOl.Size = new System.Drawing.Size(169, 32);
            this.buttonUyeOl.TabIndex = 8;
            this.buttonUyeOl.Text = "Üye Ol";
            this.buttonUyeOl.UseVisualStyleBackColor = true;
            // 
            // buttonGiris
            // 
            this.buttonGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGiris.Location = new System.Drawing.Point(41, 256);
            this.buttonGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonGiris.Name = "buttonGiris";
            this.buttonGiris.Size = new System.Drawing.Size(169, 32);
            this.buttonGiris.TabIndex = 7;
            this.buttonGiris.Text = "Giriş Yap";
            this.buttonGiris.UseVisualStyleBackColor = true;
            this.buttonGiris.Click += new System.EventHandler(this.buttonGiris_Click_1);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxSifre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxSifre.Location = new System.Drawing.Point(20, 210);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSifre.MaxLength = 16;
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(218, 32);
            this.textBoxSifre.TabIndex = 6;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxTC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxTC.Location = new System.Drawing.Point(20, 151);
            this.textBoxTC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTC.MaxLength = 11;
            this.textBoxTC.Multiline = true;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.Size = new System.Drawing.Size(218, 32);
            this.textBoxTC.TabIndex = 5;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelTC.Location = new System.Drawing.Point(23, 126);
            this.labelTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(106, 21);
            this.labelTC.TabIndex = 9;
            this.labelTC.Text = "T.C. Kimlik No";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelSifre.Location = new System.Drawing.Point(23, 185);
            this.labelSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(42, 21);
            this.labelSifre.TabIndex = 10;
            this.labelSifre.Text = "Şifre";
            // 
            // buttonDoktorGiris
            // 
            this.buttonDoktorGiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDoktorGiris.Location = new System.Drawing.Point(41, 329);
            this.buttonDoktorGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDoktorGiris.Name = "buttonDoktorGiris";
            this.buttonDoktorGiris.Size = new System.Drawing.Size(169, 32);
            this.buttonDoktorGiris.TabIndex = 11;
            this.buttonDoktorGiris.Text = "Doktor Giriş";
            this.buttonDoktorGiris.UseVisualStyleBackColor = true;
            this.buttonDoktorGiris.Click += new System.EventHandler(this.ButtonDoktorGiris_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.login_desktop_bg;
            this.pictureBox3.Location = new System.Drawing.Point(251, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(496, 374);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.Logo_of_Ministry_of_Health__Turkey_;
            this.pictureBox2.Location = new System.Drawing.Point(4, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.MHRS_Logo_1;
            this.pictureBox1.Location = new System.Drawing.Point(176, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 369);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDoktorGiris);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.buttonUyeOl);
            this.Controls.Add(this.buttonGiris);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxTC);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button buttonGiris;
        private System.Windows.Forms.Button buttonUyeOl;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Button buttonDoktorGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

