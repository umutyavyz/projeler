using System;

namespace YemekTarifleriUygulamasi
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxTarifAdi;
        private System.Windows.Forms.TextBox textBoxTarifIcerik;
        private System.Windows.Forms.TextBox textBoxTarifYapilis;
        private System.Windows.Forms.ListBox listBoxTarifler;
        private System.Windows.Forms.Button btnTarifEkle;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.Button btnTarifAra;
        private System.Windows.Forms.Label labelTarifAdi;
        private System.Windows.Forms.Label labelTarifIcerik;
        private System.Windows.Forms.Label labelTarifYapilis;
        private System.Windows.Forms.Label labelArama;
        private System.Windows.Forms.Label labelMalzemeler;
        private System.Windows.Forms.Label labelTarif;

        private void InitializeComponent()
        {
            this.textBoxTarifAdi = new System.Windows.Forms.TextBox();
            this.textBoxTarifIcerik = new System.Windows.Forms.TextBox();
            this.textBoxTarifYapilis = new System.Windows.Forms.TextBox();
            this.listBoxTarifler = new System.Windows.Forms.ListBox();
            this.btnTarifEkle = new System.Windows.Forms.Button();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.btnTarifAra = new System.Windows.Forms.Button();
            this.labelTarifAdi = new System.Windows.Forms.Label();
            this.labelTarifIcerik = new System.Windows.Forms.Label();
            this.labelTarifYapilis = new System.Windows.Forms.Label();
            this.labelArama = new System.Windows.Forms.Label();
            this.labelMalzemeler = new System.Windows.Forms.Label();
            this.labelTarif = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form Genel Ayarlar
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Text = "🍽️  Yemek Tarifleri Uygulaması";

            int leftMargin = 40;
            int top = 30;
            int labelWidth = 100;
            int inputWidth = 400;

            // labelTarifAdi
            this.labelTarifAdi.Location = new System.Drawing.Point(leftMargin, top);
            this.labelTarifAdi.Size = new System.Drawing.Size(labelWidth, 25);
            this.labelTarifAdi.Text = "Tarif Adı:";

            // textBoxTarifAdi
            this.textBoxTarifAdi.Location = new System.Drawing.Point(leftMargin + labelWidth, top);
            this.textBoxTarifAdi.Size = new System.Drawing.Size(inputWidth, 25);

            // labelTarifIcerik
            top += 40;
            this.labelTarifIcerik.Location = new System.Drawing.Point(leftMargin, top);
            this.labelTarifIcerik.Size = new System.Drawing.Size(labelWidth, 25);
            this.labelTarifIcerik.Text = "Malzemeler:";

            // textBoxTarifIcerik
            this.textBoxTarifIcerik.Location = new System.Drawing.Point(leftMargin + labelWidth, top);
            this.textBoxTarifIcerik.Size = new System.Drawing.Size(inputWidth, 25);

            // labelTarifYapilis
            top += 40;
            this.labelTarifYapilis.Location = new System.Drawing.Point(leftMargin, top);
            this.labelTarifYapilis.Size = new System.Drawing.Size(labelWidth, 25);
            this.labelTarifYapilis.Text = "Yapılış:";

            // textBoxTarifYapilis
            this.textBoxTarifYapilis.Location = new System.Drawing.Point(leftMargin + labelWidth, top);
            this.textBoxTarifYapilis.Size = new System.Drawing.Size(inputWidth, 25);

            // btnTarifEkle
            top += 50;
            this.btnTarifEkle.Location = new System.Drawing.Point(leftMargin + labelWidth, top);
            this.btnTarifEkle.Size = new System.Drawing.Size(120, 35);
            this.btnTarifEkle.Text = "➕ Tarif Ekle";
            this.btnTarifEkle.BackColor = System.Drawing.Color.LightGreen;
            this.btnTarifEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifEkle.Click += new System.EventHandler(this.btnTarifEkle_Click);

            // btnTarifAra
            this.btnTarifAra.Location = new System.Drawing.Point(leftMargin + labelWidth + 290, top);
            this.btnTarifAra.Size = new System.Drawing.Size(110, 35);
            this.btnTarifAra.Text = "🔍 Ara";
            this.btnTarifAra.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTarifAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarifAra.Click += new System.EventHandler(this.btnTarifAra_Click);

            // labelArama
            top += 50;
            this.labelArama.Location = new System.Drawing.Point(leftMargin, top);
            this.labelArama.Size = new System.Drawing.Size(labelWidth, 25);
            this.labelArama.Text = "Arama:";

            // textBoxArama
            this.textBoxArama.Location = new System.Drawing.Point(leftMargin + labelWidth, top);
            this.textBoxArama.Size = new System.Drawing.Size(inputWidth, 25);

            // listBoxTarifler
            top += 40;
            this.listBoxTarifler.Location = new System.Drawing.Point(leftMargin, top);
            this.listBoxTarifler.Size = new System.Drawing.Size(520, 100);
            this.listBoxTarifler.SelectedIndexChanged += new System.EventHandler(this.listBoxTarifler_SelectedIndexChanged);

            // labelMalzemeler
            top += 110;
            this.labelMalzemeler.Location = new System.Drawing.Point(leftMargin, top);
            this.labelMalzemeler.Size = new System.Drawing.Size(520, 60);
            this.labelMalzemeler.Text = "";
            this.labelMalzemeler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);

            // labelTarif
            top += 60;
            this.labelTarif.Location = new System.Drawing.Point(leftMargin, top);
            this.labelTarif.Size = new System.Drawing.Size(520, 100);
            this.labelTarif.Text = "";
            this.labelTarif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);

            // Form'a Elemanları Ekle
            this.Controls.Add(this.labelTarifAdi);
            this.Controls.Add(this.textBoxTarifAdi);
            this.Controls.Add(this.labelTarifIcerik);
            this.Controls.Add(this.textBoxTarifIcerik);
            this.Controls.Add(this.labelTarifYapilis);
            this.Controls.Add(this.textBoxTarifYapilis);
            this.Controls.Add(this.btnTarifEkle);
            this.Controls.Add(this.btnTarifAra);
            this.Controls.Add(this.labelArama);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.listBoxTarifler);
            this.Controls.Add(this.labelMalzemeler);
            this.Controls.Add(this.labelTarif);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
    }
