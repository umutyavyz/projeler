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
    public partial class Form1 : Form
    {
        List<Etkinlik> etkinlikListesi = new List<Etkinlik>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEtkinlikEkle_Click(object sender, EventArgs e)
        {
            Etkinlik e1 = new Etkinlik()
            {
                Id = etkinlikListesi.Count + 1,
                Ad = txtEtkinlikAd.Text,
                Tarih = dtpTarih.Value,
                Kapasite = (int)numKapasite.Value
            };
            etkinlikListesi.Add(e1);
            MessageBox.Show("Etkinlik eklendi.");
        }

        private void btnKatilimciEkle_Click(object sender, EventArgs e)
        {
            new KatilimciEkleForm().ShowDialog();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            new KayitEkleForm().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new GirisYapForm().ShowDialog();
        }
    }
}
