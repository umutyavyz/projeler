using System;
using System.Windows.Forms;

namespace EtkinlikBiletSistemi
{
    public partial class UyeOlForm : Form
    {
        public UyeOlForm()
        {
            InitializeComponent();
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            // Üye olma işlemi burada yapılacak
            MessageBox.Show("Üyelik oluşturuldu!");
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }

        private void UyeOlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
