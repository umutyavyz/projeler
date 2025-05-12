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
    public partial class AntrenmanEkleForm : Form
    {
        public AntrenmanEkleForm()
        {
            InitializeComponent();
        }

        private void AntrenmanEkleForm_Load(object sender, EventArgs e)
        {
            var dt = DatabaseHelper.ExecuteQuery("SELECT * FROM Sporcular");
            comboSporcular.DataSource = dt;
            comboSporcular.DisplayMember = "Ad";
            comboSporcular.ValueMember = "Id";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (comboSporcular.SelectedValue == null) return;

            int sporcuId = Convert.ToInt32(comboSporcular.SelectedValue);
            string adi = txtAntrenmanName.Text;
            string detay = txtDetaylar.Text;

            string query = "INSERT INTO Antrenmanlar (SporcuId, AntrenmanAdi, Detaylar) VALUES (@sid, @adi, @detay)";
            DatabaseHelper.ExecuteNonQuery(query,
                new SqlParameter("@sid", sporcuId),
                new SqlParameter("@adi", adi),
                new SqlParameter("@detay", detay));

            MessageBox.Show("Antrenman kaydettin Tebriklerr!");
        }
    }
}
