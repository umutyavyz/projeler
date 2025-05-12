using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SporTakip
{
    public partial class TakipEkleForm : Form
    {
        public TakipEkleForm()
        {
            InitializeComponent();
        }

        private void TakipEkleForm_Load(object sender, EventArgs e)
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Sporcular");
            cmbSporcular.DataSource = dt;
            cmbSporcular.DisplayMember = "Ad";
            cmbSporcular.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbSporcular.SelectedValue == null) return;

            int sporcuId = Convert.ToInt32(cmbSporcular.SelectedValue);
            string tarih = dtTarih.Value.ToString("yyyy-MM-dd");
            string aciklama = txtAciklama.Text;

            string query = "INSERT INTO Takipler (SporcuId, Tarih, Aciklama) VALUES (@sid, @tarih, @aciklama)";
            DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@sid", sporcuId),
                new SqlParameter("@tarih", tarih),
                new SqlParameter("@aciklama", aciklama));

            MessageBox.Show("Takip kaydettin Tebriklerr!");
        }
    }
}
