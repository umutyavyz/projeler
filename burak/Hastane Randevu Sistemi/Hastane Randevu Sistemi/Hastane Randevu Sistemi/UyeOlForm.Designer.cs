﻿namespace Hastane_Randevu_Sistemi
{
    partial class UyeOlForm
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
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxTC = new System.Windows.Forms.TextBox();
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.labelTC = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonKaydet.Location = new System.Drawing.Point(416, 296);
            this.buttonKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(91, 32);
            this.buttonKaydet.TabIndex = 9;
            this.buttonKaydet.Text = "Kayıt Ol";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click_1);
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxSifre.Location = new System.Drawing.Point(362, 251);
            this.textBoxSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxSifre.Size = new System.Drawing.Size(218, 32);
            this.textBoxSifre.TabIndex = 11;
            // 
            // textBoxTC
            // 
            this.textBoxTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTC.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxTC.Location = new System.Drawing.Point(362, 192);
            this.textBoxTC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTC.MaxLength = 11;
            this.textBoxTC.Multiline = true;
            this.textBoxTC.Name = "textBoxTC";
            this.textBoxTC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxTC.Size = new System.Drawing.Size(218, 32);
            this.textBoxTC.TabIndex = 10;
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxIsim.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textBoxIsim.Location = new System.Drawing.Point(362, 132);
            this.textBoxIsim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIsim.Multiline = true;
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxIsim.Size = new System.Drawing.Size(218, 32);
            this.textBoxIsim.TabIndex = 12;
            // 
            // labelTC
            // 
            this.labelTC.AutoSize = true;
            this.labelTC.BackColor = System.Drawing.SystemColors.Menu;
            this.labelTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTC.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTC.Location = new System.Drawing.Point(366, 167);
            this.labelTC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTC.Name = "labelTC";
            this.labelTC.Size = new System.Drawing.Size(106, 21);
            this.labelTC.TabIndex = 13;
            this.labelTC.Text = "T.C. Kimlik No";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.BackColor = System.Drawing.SystemColors.Menu;
            this.labelSifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelSifre.Location = new System.Drawing.Point(366, 226);
            this.labelSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(42, 21);
            this.labelSifre.TabIndex = 14;
            this.labelSifre.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(366, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "İsim Soyisim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.istockphoto_1477441021_612x612;
            this.pictureBox1.Location = new System.Drawing.Point(-328, -20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.Logo_of_Ministry_of_Health__Turkey_;
            this.pictureBox2.Location = new System.Drawing.Point(542, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hastane_Randevu_Sistemi.Properties.Resources.MHRS_Logo_1;
            this.pictureBox3.Location = new System.Drawing.Point(332, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // UyeOlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelTC);
            this.Controls.Add(this.textBoxIsim);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxTC);
            this.Controls.Add(this.buttonKaydet);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UyeOlForm";
            this.Text = "UyeOlForm";
            this.Load += new System.EventHandler(this.UyeOlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxTC;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.Label labelTC;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}