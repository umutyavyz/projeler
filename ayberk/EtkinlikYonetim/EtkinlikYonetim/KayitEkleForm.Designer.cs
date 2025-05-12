namespace EtkinlikYonetim
{
    partial class KayitEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KayitEkleForm));
            this.cmbEtkinlikler = new System.Windows.Forms.ComboBox();
            this.txtKatilimciTC = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbEtkinlikler
            // 
            this.cmbEtkinlikler.FormattingEnabled = true;
            this.cmbEtkinlikler.Location = new System.Drawing.Point(196, 85);
            this.cmbEtkinlikler.Name = "cmbEtkinlikler";
            this.cmbEtkinlikler.Size = new System.Drawing.Size(121, 21);
            this.cmbEtkinlikler.TabIndex = 0;
            // 
            // txtKatilimciTC
            // 
            this.txtKatilimciTC.Location = new System.Drawing.Point(196, 113);
            this.txtKatilimciTC.MaxLength = 11;
            this.txtKatilimciTC.Name = "txtKatilimciTC";
            this.txtKatilimciTC.Size = new System.Drawing.Size(121, 20);
            this.txtKatilimciTC.TabIndex = 1;
            this.txtKatilimciTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKatilimciTC_KeyPress);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(352, 85);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(75, 48);
            this.btnKayit.TabIndex = 2;
            this.btnKayit.Text = "Kayıt";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Katılımcı TC Kimlik Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Etkinlik Seçimi";
            // 
            // KayitEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(507, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.txtKatilimciTC);
            this.Controls.Add(this.cmbEtkinlikler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KayitEkleForm";
            this.Text = "BuBilet | Kayıt Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEtkinlikler;
        private System.Windows.Forms.TextBox txtKatilimciTC;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}