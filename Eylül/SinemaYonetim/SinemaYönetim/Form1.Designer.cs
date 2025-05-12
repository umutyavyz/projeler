using System;

namespace SinemaYonetim
{
    partial class Form1
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

        private void InitializeComponent()
        {
            this.comboBoxFilmler = new System.Windows.Forms.ComboBox();
            this.comboBoxBiletTipi = new System.Windows.Forms.ComboBox();
            this.comboBoxSalon = new System.Windows.Forms.ComboBox();
            this.numericUpDownBiletSayisi = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxFilm = new System.Windows.Forms.PictureBox();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBiletSayisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilmler
            // 
            this.comboBoxFilmler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilmler.FormattingEnabled = true;
            this.comboBoxFilmler.Location = new System.Drawing.Point(234, 66);
            this.comboBoxFilmler.Name = "comboBoxFilmler";
            this.comboBoxFilmler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilmler.TabIndex = 0;
            this.comboBoxFilmler.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilmler_SelectedIndexChanged);
            // 
            // comboBoxBiletTipi
            // 
            this.comboBoxBiletTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBiletTipi.FormattingEnabled = true;
            this.comboBoxBiletTipi.Location = new System.Drawing.Point(234, 120);
            this.comboBoxBiletTipi.Name = "comboBoxBiletTipi";
            this.comboBoxBiletTipi.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBiletTipi.TabIndex = 1;
            this.comboBoxBiletTipi.SelectedIndexChanged += new System.EventHandler(this.comboBoxBiletTipi_SelectedIndexChanged);
            // 
            // comboBoxSalon
            // 
            this.comboBoxSalon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalon.FormattingEnabled = true;
            this.comboBoxSalon.Location = new System.Drawing.Point(234, 171);
            this.comboBoxSalon.Name = "comboBoxSalon";
            this.comboBoxSalon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSalon.TabIndex = 2;
            // 
            // numericUpDownBiletSayisi
            // 
            this.numericUpDownBiletSayisi.Location = new System.Drawing.Point(235, 210);
            this.numericUpDownBiletSayisi.Name = "numericUpDownBiletSayisi";
            this.numericUpDownBiletSayisi.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBiletSayisi.TabIndex = 3;
            // 
            // pictureBoxFilm
            // 
            this.pictureBoxFilm.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFilm.Name = "pictureBoxFilm";
            this.pictureBoxFilm.Size = new System.Drawing.Size(200, 319);
            this.pictureBoxFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFilm.TabIndex = 4;
            this.pictureBoxFilm.TabStop = false;
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(235, 246);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(121, 23);
            this.btnBiletAl.TabIndex = 5;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salon Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bilet Tipi Seçin";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.pictureBoxFilm);
            this.Controls.Add(this.numericUpDownBiletSayisi);
            this.Controls.Add(this.comboBoxSalon);
            this.Controls.Add(this.comboBoxBiletTipi);
            this.Controls.Add(this.comboBoxFilmler);
            this.Name = "Form1";
            this.Text = "Sinema Bileti Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBiletSayisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFilm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxFilmler;
        private System.Windows.Forms.ComboBox comboBoxBiletTipi;
        private System.Windows.Forms.ComboBox comboBoxSalon;
        private System.Windows.Forms.NumericUpDown numericUpDownBiletSayisi;
        private System.Windows.Forms.PictureBox pictureBoxFilm;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
