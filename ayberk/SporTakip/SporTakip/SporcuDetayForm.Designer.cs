namespace SporTakip
{
    partial class SporcuDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SporcuDetayForm));
            this.cmbSporcular = new System.Windows.Forms.ComboBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lstAntrenmanlar = new System.Windows.Forms.ListBox();
            this.lstTakipler = new System.Windows.Forms.ListBox();
            this.lblAntrenman = new System.Windows.Forms.Label();
            this.lblTakip = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSporcular
            // 
            this.cmbSporcular.FormattingEnabled = true;
            this.cmbSporcular.Location = new System.Drawing.Point(313, 171);
            this.cmbSporcular.Name = "cmbSporcular";
            this.cmbSporcular.Size = new System.Drawing.Size(121, 21);
            this.cmbSporcular.TabIndex = 0;
            this.cmbSporcular.Text = "Sporcu seç";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(313, 232);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Listeyi Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // lstAntrenmanlar
            // 
            this.lstAntrenmanlar.FormattingEnabled = true;
            this.lstAntrenmanlar.Location = new System.Drawing.Point(38, 97);
            this.lstAntrenmanlar.Name = "lstAntrenmanlar";
            this.lstAntrenmanlar.Size = new System.Drawing.Size(217, 95);
            this.lstAntrenmanlar.TabIndex = 2;
            // 
            // lstTakipler
            // 
            this.lstTakipler.FormattingEnabled = true;
            this.lstTakipler.Location = new System.Drawing.Point(38, 232);
            this.lstTakipler.Name = "lstTakipler";
            this.lstTakipler.Size = new System.Drawing.Size(217, 95);
            this.lstTakipler.TabIndex = 3;
            // 
            // lblAntrenman
            // 
            this.lblAntrenman.AutoSize = true;
            this.lblAntrenman.ForeColor = System.Drawing.SystemColors.Window;
            this.lblAntrenman.Location = new System.Drawing.Point(35, 70);
            this.lblAntrenman.Name = "lblAntrenman";
            this.lblAntrenman.Size = new System.Drawing.Size(69, 13);
            this.lblAntrenman.TabIndex = 4;
            this.lblAntrenman.Text = "Antrenmanlar";
            // 
            // lblTakip
            // 
            this.lblTakip.AutoSize = true;
            this.lblTakip.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTakip.Location = new System.Drawing.Point(35, 206);
            this.lblTakip.Name = "lblTakip";
            this.lblTakip.Size = new System.Drawing.Size(45, 13);
            this.lblTakip.TabIndex = 5;
            this.lblTakip.Text = "Takipler";
            // 
            // SporcuDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.lblTakip);
            this.Controls.Add(this.lblAntrenman);
            this.Controls.Add(this.lstTakipler);
            this.Controls.Add(this.lstAntrenmanlar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbSporcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SporcuDetayForm";
            this.Text = "Spor Istanbul | Sporcu Detayı";
            this.Load += new System.EventHandler(this.SporcuDetayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSporcular;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ListBox lstAntrenmanlar;
        private System.Windows.Forms.ListBox lstTakipler;
        private System.Windows.Forms.Label lblAntrenman;
        private System.Windows.Forms.Label lblTakip;
    }
}