using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EtkinlikBiletSistemi
{
    public partial class Form1 : Form
    {
        List<Etkinlik> etkinlikler = new List<Etkinlik>();
        List<Bilet> kullaniciBiletleri = new List<Bilet>();
        Kullanici aktifKullanici = new Kullanici("test", "test123");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEtkinlikEkle_Click(object sender, EventArgs e)
        {
            string etkinlikAdi = txtEtkinlikAdi.Text;
            DateTime etkinlikTarihi = dtpEtkinlikTarihi.Value;
            int biletSayisi;
            decimal biletFiyati;

            if (string.IsNullOrWhiteSpace(etkinlikAdi))
            {
                MessageBox.Show("Lütfen etkinlik adını giriniz.");
                return;
            }

            if (!int.TryParse(txtBiletSayisi.Text, out biletSayisi) || biletSayisi <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir bilet sayısı giriniz.");
                return;
            }

            if (!decimal.TryParse(txtBiletFiyati.Text, out biletFiyati) || biletFiyati <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir bilet fiyatı giriniz.");
                return;
            }

            Etkinlik yeni = new Etkinlik(etkinlikAdi, etkinlikTarihi, "İstanbul", biletSayisi, biletFiyati);
            etkinlikler.Add(yeni);
            lstEtkinlikler.Items.Add(yeni);

            MessageBox.Show("Etkinlik başarıyla eklendi.");
        }

        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (lstEtkinlikler.SelectedItem != null)
            {
                Etkinlik secilen = (Etkinlik)lstEtkinlikler.SelectedItem;
                if (secilen.BiletAdedi > 0)
                {
                    Bilet bilet = new Bilet(secilen);
                    kullaniciBiletleri.Add(bilet);
                    lstBiletler.Items.Add(bilet);
                    secilen.BiletAdedi--;
                    lstEtkinlikler.Items[lstEtkinlikler.SelectedIndex] = secilen; // Listeyi güncelle
                    MessageBox.Show("Bilet alındı.");
                }
                else
                {
                    MessageBox.Show("Bilet kalmadı.");
                }
            }
        }

        // Sınıflar
        public class Etkinlik
        {
            public string Ad { get; set; }
            public DateTime Tarih { get; set; }
            public string Mekan { get; set; }
            public int BiletAdedi { get; set; }
            public decimal BiletFiyati { get; set; } // Yeni Özellik

            public Etkinlik(string ad, DateTime tarih, string mekan, int biletAdedi, decimal biletFiyati)
            {
                Ad = ad;
                Tarih = tarih;
                Mekan = mekan;
                BiletAdedi = biletAdedi;
                BiletFiyati = biletFiyati;
            }

            public override string ToString()
            {
                return $"{Ad} - {Tarih.ToShortDateString()} - {Mekan} ({BiletAdedi} bilet, {BiletFiyati:C} fiyat)";
            }
        }

        public class Bilet
        {
            public Etkinlik Etkinlik { get; set; }

            public Bilet(Etkinlik etkinlik)
            {
                Etkinlik = etkinlik;
            }

            public override string ToString()
            {
                return $"Bilet: {Etkinlik.Ad} ({Etkinlik.Tarih.ToShortDateString()})";
            }
        }

        public class Kullanici
        {
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }

            public Kullanici(string adi, string sifre)
            {
                KullaniciAdi = adi;
                Sifre = sifre;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBiletSayisi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBiletFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
