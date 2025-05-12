namespace OnlineEgitimPlatformu
{
    partial class MainForm
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
            this.lstKurslar = new System.Windows.Forms.ListBox();
            this.btnKursDetay = new System.Windows.Forms.Button();
            this.btnDersSec = new System.Windows.Forms.Button();
            this.btnKurslarim = new System.Windows.Forms.Button();
            this.lblhosgeldin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstKurslar
            // 
            this.lstKurslar.FormattingEnabled = true;
            this.lstKurslar.Location = new System.Drawing.Point(12, 41);
            this.lstKurslar.Margin = new System.Windows.Forms.Padding(2);
            this.lstKurslar.Name = "lstKurslar";
            this.lstKurslar.Size = new System.Drawing.Size(360, 199);
            this.lstKurslar.TabIndex = 0;
            // 
            // btnKursDetay
            // 
            this.btnKursDetay.Location = new System.Drawing.Point(12, 246);
            this.btnKursDetay.Margin = new System.Windows.Forms.Padding(2);
            this.btnKursDetay.Name = "btnKursDetay";
            this.btnKursDetay.Size = new System.Drawing.Size(110, 30);
            this.btnKursDetay.TabIndex = 1;
            this.btnKursDetay.Text = "Kurs Detayları";
            this.btnKursDetay.UseVisualStyleBackColor = true;
            this.btnKursDetay.Click += new System.EventHandler(this.btnKursDetay_Click);
            // 
            // btnDersSec
            // 
            this.btnDersSec.Location = new System.Drawing.Point(136, 246);
            this.btnDersSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnDersSec.Name = "btnDersSec";
            this.btnDersSec.Size = new System.Drawing.Size(110, 30);
            this.btnDersSec.TabIndex = 2;
            this.btnDersSec.Text = "Ders Seç";
            this.btnDersSec.UseVisualStyleBackColor = true;
            this.btnDersSec.Click += new System.EventHandler(this.btnDersSec_Click);
            // 
            // btnKurslarim
            // 
            this.btnKurslarim.Location = new System.Drawing.Point(258, 246);
            this.btnKurslarim.Margin = new System.Windows.Forms.Padding(2);
            this.btnKurslarim.Name = "btnKurslarim";
            this.btnKurslarim.Size = new System.Drawing.Size(110, 30);
            this.btnKurslarim.TabIndex = 3;
            this.btnKurslarim.Text = "Kurslarım";
            this.btnKurslarim.UseVisualStyleBackColor = true;
            this.btnKurslarim.Click += new System.EventHandler(this.btnKurslarim_Click);
            // 
            // lblhosgeldin
            // 
            this.lblhosgeldin.AutoSize = true;
            this.lblhosgeldin.Location = new System.Drawing.Point(12, 9);
            this.lblhosgeldin.Name = "lblhosgeldin";
            this.lblhosgeldin.Size = new System.Drawing.Size(10, 13);
            this.lblhosgeldin.TabIndex = 4;
            this.lblhosgeldin.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 295);
            this.Controls.Add(this.lblhosgeldin);
            this.Controls.Add(this.btnKurslarim);
            this.Controls.Add(this.btnDersSec);
            this.Controls.Add(this.btnKursDetay);
            this.Controls.Add(this.lstKurslar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Öğrenci Paneli";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstKurslar;
        private System.Windows.Forms.Button btnKursDetay;
        private System.Windows.Forms.Button btnDersSec;
        private System.Windows.Forms.Button btnKurslarim;
        private System.Windows.Forms.Label lblhosgeldin;
    }
}
