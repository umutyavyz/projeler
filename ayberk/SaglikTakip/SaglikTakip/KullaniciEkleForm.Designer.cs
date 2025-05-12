namespace SaglikTakip
{
    partial class KullaniciEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciEkleForm));
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxyas = new System.Windows.Forms.TextBox();
            this.comboBoxcins = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(231, 41);
            this.textBoxad.MaxLength = 16;
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 20);
            this.textBoxad.TabIndex = 0;
            this.textBoxad.Text = "Ad";
            // 
            // textBoxyas
            // 
            this.textBoxyas.Location = new System.Drawing.Point(231, 67);
            this.textBoxyas.MaxLength = 3;
            this.textBoxyas.Name = "textBoxyas";
            this.textBoxyas.Size = new System.Drawing.Size(100, 20);
            this.textBoxyas.TabIndex = 1;
            this.textBoxyas.Text = "Yaş";
            this.textBoxyas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // comboBoxcins
            // 
            this.comboBoxcins.FormattingEnabled = true;
            this.comboBoxcins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın",
            "Diğer"});
            this.comboBoxcins.Location = new System.Drawing.Point(85, 41);
            this.comboBoxcins.Name = "comboBoxcins";
            this.comboBoxcins.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcins.TabIndex = 2;
            this.comboBoxcins.Text = "Cinsiyet";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(231, 103);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // KullaniciEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(409, 169);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.comboBoxcins);
            this.Controls.Add(this.textBoxyas);
            this.Controls.Add(this.textBoxad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciEkleForm";
            this.Text = "Saglik Gov TR | Kullanici Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxyas;
        private System.Windows.Forms.ComboBox comboBoxcins;
        private System.Windows.Forms.Button btnKaydet;
    }
}