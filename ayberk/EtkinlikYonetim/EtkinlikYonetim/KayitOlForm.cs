using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetim
{
    public partial class KayitOlForm : Form
    {
        public static Dictionary<string, string> kullaniciVerileri = new Dictionary<string, string>();
        public KayitOlForm()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;

            if (kullaniciAdi == "" || sifre == "")
            {
                MessageBox.Show("Alanları boş bırakmayın.");
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            using (var baglanti = new SqliteConnection(DatabaseHelper.baglantiYolu))
            {
                baglanti.Open();

                // Aynı kullanıcı adı var mı kontrol
                string kontrolSorgu = "SELECT COUNT(*) FROM Kullanici WHERE KullaniciAdi = @kullaniciAdi";
                using (var komut = new SqliteCommand(kontrolSorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    long sayi = (long)komut.ExecuteScalar();

                    if (sayi > 0)
                    {
                        MessageBox.Show("Bu kullanıcı adı zaten kayıtlı.");
                        return;
                    }
                }

                string ekleSorgu = "INSERT INTO Kullanici (KullaniciAdi, Sifre) VALUES (@kullaniciAdi, @sifre)";
                using (var komut = new SqliteCommand(ekleSorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    komut.Parameters.AddWithValue("@sifre", sifre);
                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Kayıt başarılı!");
                this.Close();
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin TextBox'a yazılmasını engeller
            }
        }
    }
}
