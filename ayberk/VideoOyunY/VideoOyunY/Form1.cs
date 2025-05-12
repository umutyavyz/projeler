using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoOyunY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOyunEkle_Click(object sender, EventArgs e)
        {
            new OyunEkleForm().ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            new OyunListeleForm().ShowDialog();
        }

        private void btnDegerlendir_Click(object sender, EventArgs e)
        {
           
        }

        private void btnOneri_Click(object sender, EventArgs e)
        {
           OyunOneriForm oyunOneriForm = new OyunOneriForm();
            oyunOneriForm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
