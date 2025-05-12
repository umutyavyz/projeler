using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetim
{
    public partial class GirisYapForm : Form
    {
        Dictionary<string, string> kullaniciVerileri = new Dictionary<string, string>()
    {
        { "admin", "admin" },
        { "kullanici", "sifre" }
    };
        public GirisYapForm()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin.");
                return;
            }

            string query = "SELECT * FROM Kullanicilar WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre";
            SqlParameter[] parameters = {
            new SqlParameter("@kullaniciAdi", kullaniciAdi),
            new SqlParameter("@sifre", sifre)
        };

            DataTable sonuc = DatabaseHelper.ExecuteQuery(query, parameters);

            if (sonuc.Rows.Count > 0)
            {
                // Giriş başarılı
                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Hide(); // Login formunu gizle
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
        
        private void GirisYapForm_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new KayitOlForm().ShowDialog();
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
