namespace SporTakip
{
    partial class AntrenmanEkleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AntrenmanEkleForm));
            this.comboSporcular = new System.Windows.Forms.ComboBox();
            this.txtAntrenmanName = new System.Windows.Forms.TextBox();
            this.txtDetaylar = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboSporcular
            // 
            this.comboSporcular.FormattingEnabled = true;
            this.comboSporcular.Location = new System.Drawing.Point(92, 50);
            this.comboSporcular.Name = "comboSporcular";
            this.comboSporcular.Size = new System.Drawing.Size(121, 21);
            this.comboSporcular.TabIndex = 0;
            this.comboSporcular.Text = "Sporcu seç";
            // 
            // txtAntrenmanName
            // 
            this.txtAntrenmanName.Location = new System.Drawing.Point(258, 50);
            this.txtAntrenmanName.Name = "txtAntrenmanName";
            this.txtAntrenmanName.Size = new System.Drawing.Size(100, 20);
            this.txtAntrenmanName.TabIndex = 1;
            this.txtAntrenmanName.Text = "Antrenman adı";
            // 
            // txtDetaylar
            // 
            this.txtDetaylar.Location = new System.Drawing.Point(258, 76);
            this.txtDetaylar.Name = "txtDetaylar";
            this.txtDetaylar.Size = new System.Drawing.Size(100, 20);
            this.txtDetaylar.TabIndex = 2;
            this.txtDetaylar.Text = "Antrenman detay";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(272, 138);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // AntrenmanEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(483, 211);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtDetaylar);
            this.Controls.Add(this.txtAntrenmanName);
            this.Controls.Add(this.comboSporcular);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AntrenmanEkleForm";
            this.Text = "Spor Istanbul | Antrenman Ekle";
            this.Load += new System.EventHandler(this.AntrenmanEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSporcular;
        private System.Windows.Forms.TextBox txtAntrenmanName;
        private System.Windows.Forms.TextBox txtDetaylar;
        private System.Windows.Forms.Button btnKaydet;
    }
}