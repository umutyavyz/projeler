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
    public partial class KayitEkleForm : Form
    {
        List<Katilim> katilimciListesi = new List<Katilim>();
        List<Etkinlik> etkinlikListesi = new List<Etkinlik>();
        List<Bilet> biletListesi = new List<Bilet>();
        public KayitEkleForm()
        {
            InitializeComponent();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            int etkinlikId = (int)cmbEtkinlikler.SelectedValue;
            int tc = int.Parse(txtKatilimciTC.Text);

            var etkinlik = etkinlikListesi.FirstOrDefault(e1 => e1.Id == etkinlikId);
            var katilimci = katilimciListesi.FirstOrDefault(k => k.TcKimlik == tc);

            if (etkinlik != null && katilimci != null && etkinlik.KatilimciEkle(katilimci))
            {
                Bilet bilet = new Bilet()
                {
                    BiletId = biletListesi.Count + 1,
                    Katilimci = katilimci,
                    Etkinlik = etkinlik
                };
                biletListesi.Add(bilet);
                MessageBox.Show("Kayıt başarılı, bilet oluşturuldu.");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız. Etkinlik dolu olabilir.");
            }
        }

        private void txtKatilimciTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
