namespace AracKiralamaUygulaması
{
    partial class KiralamaForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.lblVites = new System.Windows.Forms.Label();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblYakitTipi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGunSayisi = new System.Windows.Forms.TextBox();
            this.btnArtir = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnOdemeyeGec = new System.Windows.Forms.Button();
            this.lblGunlukUcret = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(342, 91);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 13);
            this.lblMarka.TabIndex = 1;
            this.lblMarka.Text = "lblMarka";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(343, 114);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 13);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "lblModel";
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Location = new System.Drawing.Point(343, 138);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(28, 13);
            this.lblYil.TabIndex = 3;
            this.lblYil.Text = "lblYil";
            // 
            // lblVites
            // 
            this.lblVites.AutoSize = true;
            this.lblVites.Location = new System.Drawing.Point(348, 165);
            this.lblVites.Name = "lblVites";
            this.lblVites.Size = new System.Drawing.Size(40, 13);
            this.lblVites.TabIndex = 4;
            this.lblVites.Text = "lblVites";
            this.lblVites.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(351, 211);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(43, 13);
            this.lblRenk.TabIndex = 5;
            this.lblRenk.Text = "lblRenk";
            // 
            // lblYakitTipi
            // 
            this.lblYakitTipi.AutoSize = true;
            this.lblYakitTipi.Location = new System.Drawing.Point(347, 188);
            this.lblYakitTipi.Name = "lblYakitTipi";
            this.lblYakitTipi.Size = new System.Drawing.Size(58, 13);
            this.lblYakitTipi.TabIndex = 6;
            this.lblYakitTipi.Text = "lblYakitTipi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gün Sayısı";
            // 
            // txtGunSayisi
            // 
            this.txtGunSayisi.Location = new System.Drawing.Point(541, 139);
            this.txtGunSayisi.MaxLength = 3;
            this.txtGunSayisi.Name = "txtGunSayisi";
            this.txtGunSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtGunSayisi.TabIndex = 8;
            this.txtGunSayisi.Text = "1";
            this.txtGunSayisi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGunSayisi_KeyDown);
            this.txtGunSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGunSayisi_KeyPress);
            this.txtGunSayisi.Leave += new System.EventHandler(this.txtGunSayisi_Leave);
            this.txtGunSayisi.Validating += new System.ComponentModel.CancelEventHandler(this.txtGunSayisi_Validating);
            // 
            // btnArtir
            // 
            this.btnArtir.Location = new System.Drawing.Point(647, 137);
            this.btnArtir.Name = "btnArtir";
            this.btnArtir.Size = new System.Drawing.Size(28, 23);
            this.btnArtir.TabIndex = 9;
            this.btnArtir.Text = "+";
            this.btnArtir.UseVisualStyleBackColor = true;
            this.btnArtir.Click += new System.EventHandler(this.btnArtir_Click_1);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(507, 137);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(28, 23);
            this.btnAzalt.TabIndex = 10;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click_1);
            // 
            // btnOdemeyeGec
            // 
            this.btnOdemeyeGec.Location = new System.Drawing.Point(532, 205);
            this.btnOdemeyeGec.Name = "btnOdemeyeGec";
            this.btnOdemeyeGec.Size = new System.Drawing.Size(120, 23);
            this.btnOdemeyeGec.TabIndex = 11;
            this.btnOdemeyeGec.Text = "Ödemeye Geç";
            this.btnOdemeyeGec.UseVisualStyleBackColor = true;
            this.btnOdemeyeGec.Click += new System.EventHandler(this.btnOdemeyeGec_Click_1);
            // 
            // lblGunlukUcret
            // 
            this.lblGunlukUcret.AutoSize = true;
            this.lblGunlukUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGunlukUcret.Location = new System.Drawing.Point(362, 241);
            this.lblGunlukUcret.Name = "lblGunlukUcret";
            this.lblGunlukUcret.Size = new System.Drawing.Size(128, 20);
            this.lblGunlukUcret.TabIndex = 12;
            this.lblGunlukUcret.Text = "lblGunlukUcret";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(73, 55);
            this.btnGeri.TabIndex = 13;
            this.btnGeri.Text = "Geri Dön";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yıl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vites Tipi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Renk:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Yakıt Tipi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Günlük Ücret:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 21;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(525, 174);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(67, 20);
            this.lblToplamTutar.TabIndex = 22;
            this.lblToplamTutar.Text = "label10";
            this.lblToplamTutar.Visible = false;
            // 
            // KiralamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 323);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblGunlukUcret);
            this.Controls.Add(this.btnOdemeyeGec);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnArtir);
            this.Controls.Add(this.txtGunSayisi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblYakitTipi);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.lblVites);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KiralamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiralamaForm";
            this.Load += new System.EventHandler(this.KiralamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label lblVites;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label lblYakitTipi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGunSayisi;
        private System.Windows.Forms.Button btnArtir;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnOdemeyeGec;
        private System.Windows.Forms.Label lblGunlukUcret;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}