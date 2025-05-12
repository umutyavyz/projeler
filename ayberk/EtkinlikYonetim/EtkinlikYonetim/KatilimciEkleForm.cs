using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetim
{
    public partial class KatilimciEkleForm : Form
    {
        List<Katilim> katilimciListesi = new List<Katilim>();
        public KatilimciEkleForm()
        {
            InitializeComponent();
        }

        private void btnKatilimciEkle_Click(object sender, EventArgs e)
        {
            Katilim k1 = new Katilim()
            {
                TcKimlik = int.Parse(txtTC.Text),
                AdSoyad = txtAdSoyad.Text,
                Email = txtEmail.Text
            };
            katilimciListesi.Add(k1);
            MessageBox.Show("Katılımcı eklendi.");
        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin yazılmasını engeller
            }
        }

        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // karakterin TextBox'a yazılmasını engeller
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, pattern))
            {
                lblUyari.Text = "Geçersiz e-posta adresi!";
                lblUyari.ForeColor = Color.Red;
            }
            else
            {
                lblUyari.Text = "Geçerli E-posta Adresi!";
            }
        }
    }
}
