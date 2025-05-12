namespace Hastane_Randevu_Sistemi
{
    partial class DoktorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelDoktor;
        private System.Windows.Forms.ListBox listBoxRandevular;
        private System.Windows.Forms.Button buttonCikis;

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
            this.labelDoktor = new System.Windows.Forms.Label();
            this.listBoxRandevular = new System.Windows.Forms.ListBox();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDoktor
            // 
            this.labelDoktor.AutoSize = true;
            this.labelDoktor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDoktor.Location = new System.Drawing.Point(15, 16);
            this.labelDoktor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDoktor.Name = "labelDoktor";
            this.labelDoktor.Size = new System.Drawing.Size(104, 21);
            this.labelDoktor.TabIndex = 0;
            this.labelDoktor.Text = "Hoş geldiniz...";
            // 
            // listBoxRandevular
            // 
            this.listBoxRandevular.FormattingEnabled = true;
            this.listBoxRandevular.Location = new System.Drawing.Point(17, 65);
            this.listBoxRandevular.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxRandevular.Name = "listBoxRandevular";
            this.listBoxRandevular.Size = new System.Drawing.Size(272, 147);
            this.listBoxRandevular.TabIndex = 2;
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(17, 244);
            this.buttonCikis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(75, 24);
            this.buttonCikis.TabIndex = 3;
            this.buttonCikis.Text = "Çıkış";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 284);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.listBoxRandevular);
            this.Controls.Add(this.labelDoktor);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DoktorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
