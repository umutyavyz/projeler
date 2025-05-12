namespace OnlineEgitimPlatformu
{
    partial class KursNotlariForm
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
            this.lblKursAdi = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lstKurslar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblKursAdi
            // 
            this.lblKursAdi.AutoSize = true;
            this.lblKursAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKursAdi.Location = new System.Drawing.Point(9, 9);
            this.lblKursAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKursAdi.Name = "lblKursAdi";
            this.lblKursAdi.Size = new System.Drawing.Size(76, 20);
            this.lblKursAdi.TabIndex = 0;
            this.lblKursAdi.Text = "Kurs Adı";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(13, 301);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 24);
            this.btnGeri.TabIndex = 2;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // lstKurslar
            // 
            this.lstKurslar.FormattingEnabled = true;
            this.lstKurslar.Location = new System.Drawing.Point(13, 32);
            this.lstKurslar.Name = "lstKurslar";
            this.lstKurslar.Size = new System.Drawing.Size(337, 264);
            this.lstKurslar.TabIndex = 3;
            // 
            // KursNotlariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(362, 336);
            this.Controls.Add(this.lstKurslar);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblKursAdi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KursNotlariForm";
            this.Text = "Kurs Notları";
            this.Load += new System.EventHandler(this.KursNotlariForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKursAdi;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListBox lstKurslar;
    }
}
