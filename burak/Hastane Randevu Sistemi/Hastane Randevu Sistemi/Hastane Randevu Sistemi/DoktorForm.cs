using System;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hastane_Randevu_Sistemi
{
    public partial class DoktorForm : Form
    {
        private int girisYapanDoktorID;
        private string girisYapanDoktorAdSoyad;

        public DoktorForm(int doktorID, string doktorAdSoyad)
        {
            InitializeComponent();
            girisYapanDoktorID = doktorID;
            girisYapanDoktorAdSoyad = doktorAdSoyad;
        }

        private void DoktorForm_Load(object sender, EventArgs e)
        {
            labelDoktor.Text = "Hoşgeldiniz, " + girisYapanDoktorAdSoyad;
            RandevuListele();
        }


        private void RandevuListele()
        {
            string query = @"
        SELECT R.RandevuTarihi, H.Ad_Soyad
        FROM Randevular R
        JOIN Hastalar H ON R.HastaID = H.HastaID
        WHERE R.DoktorID = @DoktorID
        ORDER BY R.RandevuTarihi";

            SqlParameter[] param = {
        new SqlParameter("@DoktorID", girisYapanDoktorID)
    };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, param);

            listBoxRandevular.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                DateTime tarih = Convert.ToDateTime(row["RandevuTarihi"]);
                string hastaAdSoyad = row["Ad_Soyad"].ToString();
                listBoxRandevular.Items.Add($"{tarih:g} - {hastaAdSoyad}");
            }
        }


        private void checkBoxMusait_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
