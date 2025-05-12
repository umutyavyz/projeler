namespace OnlineEgitimPlatformu
{
    partial class KursDetayForm
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
            this.lblEgitmen = new System.Windows.Forms.Label();
            this.lblUzmanlik = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstbNotlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKursAdi
            // 
            this.lblKursAdi.AutoSize = true;
            this.lblKursAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKursAdi.Location = new System.Drawing.Point(12, 9);
            this.lblKursAdi.Name = "lblKursAdi";
            this.lblKursAdi.Size = new System.Drawing.Size(69, 17);
            this.lblKursAdi.TabIndex = 0;
            this.lblKursAdi.Text = "Kurs Adı";
            // 
            // lblEgitmen
            // 
            this.lblEgitmen.AutoSize = true;
            this.lblEgitmen.Location = new System.Drawing.Point(12, 36);
            this.lblEgitmen.Name = "lblEgitmen";
            this.lblEgitmen.Size = new System.Drawing.Size(45, 13);
            this.lblEgitmen.TabIndex = 1;
            this.lblEgitmen.Text = "Eğitmen";
            // 
            // lblUzmanlik
            // 
            this.lblUzmanlik.AutoSize = true;
            this.lblUzmanlik.Location = new System.Drawing.Point(9, 55);
            this.lblUzmanlik.Name = "lblUzmanlik";
            this.lblUzmanlik.Size = new System.Drawing.Size(76, 13);
            this.lblUzmanlik.TabIndex = 2;
            this.lblUzmanlik.Text = "Uzmanlık Alanı";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(240, 241);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.Location = new System.Drawing.Point(15, 168);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(300, 69);
            this.lstOgrenciler.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kayıtlı Öğrenciler:";
            // 
            // lstbNotlar
            // 
            this.lstbNotlar.FormattingEnabled = true;
            this.lstbNotlar.Location = new System.Drawing.Point(15, 91);
            this.lstbNotlar.Name = "lstbNotlar";
            this.lstbNotlar.Size = new System.Drawing.Size(300, 56);
            this.lstbNotlar.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Notlar:";
            // 
            // KursDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(327, 276);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbNotlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblUzmanlik);
            this.Controls.Add(this.lblEgitmen);
            this.Controls.Add(this.lblKursAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KursDetayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kurs Detayları";
            this.Load += new System.EventHandler(this.KursDetayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKursAdi;
        private System.Windows.Forms.Label lblEgitmen;
        private System.Windows.Forms.Label lblUzmanlik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ListBox lstOgrenciler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstbNotlar;
        private System.Windows.Forms.Label label1;
    }
}