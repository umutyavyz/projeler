using System;
using System.Windows.Forms;

namespace EtkinlikBiletSistemi
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (kullaniciAdi == "test" && sifre == "test123")  // Bu kısmı veritabanı ile değiştirebilirsin
            {
                MessageBox.Show("Giriş başarılı!");
                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
            }
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOlForm uyeOlForm = new UyeOlForm();
            uyeOlForm.Show();
            this.Hide();
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }
    }
}
