using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace YemekTarifleriUygulamasi
{
    public partial class Form1 : Form
    {
        private static readonly string dbPath = Path.Combine(Application.StartupPath, @"..\..\Veri\YemekTarifleriDB.mdf");
        private static readonly string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Path.GetFullPath(dbPath)};Integrated Security=True;";
        private List<Tarif> tarifler = new List<Tarif>();

        public Form1()
        {
            InitializeComponent();
            TarifleriYukle();
        }

        private void TarifleriYukle()
        {
            tarifler.Clear();
            listBoxTarifler.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tarifler", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Tarif t = new Tarif
                    {
                        Id = (int)reader["Id"],
                        Ad = reader["Ad"].ToString(),
                        Icerik = reader["Icerik"].ToString(),
                        Yapilis = reader["Yapilis"].ToString()
                    };
                    tarifler.Add(t);
                    listBoxTarifler.Items.Add(t.Ad);
                }
            }
        }

        private void btnTarifEkle_Click(object sender, EventArgs e)
        {
            string ad = textBoxTarifAdi.Text.Trim();
            string icerik = textBoxTarifIcerik.Text.Trim();
            string yapilis = textBoxTarifYapilis.Text.Trim();

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(icerik) || string.IsNullOrWhiteSpace(yapilis))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Tarifler (Ad, Icerik, Yapilis) VALUES (@Ad, @Icerik, @Yapilis)", conn);
                cmd.Parameters.AddWithValue("@Ad", ad);
                cmd.Parameters.AddWithValue("@Icerik", icerik);
                cmd.Parameters.AddWithValue("@Yapilis", yapilis);
                cmd.ExecuteNonQuery();
            }

            textBoxTarifAdi.Clear();
            textBoxTarifIcerik.Clear();
            textBoxTarifYapilis.Clear();
            TarifleriYukle();
        }
        private void btnTarifAra_Click(object sender, EventArgs e)
        {
            string aranan = textBoxArama.Text.Trim();

            if (string.IsNullOrWhiteSpace(aranan))
            {
                MessageBox.Show("Lütfen aramak istediğiniz tarif adını girin.");
                return;
            }

            listBoxTarifler.Items.Clear();

            string query = "SELECT * FROM Tarifler WHERE Ad LIKE @aranan";

            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\YemekTarifleriDB.mdf;Integrated Security=True"))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@aranan", "%" + aranan + "%");

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ad = reader["Ad"].ToString();

                            listBoxTarifler.Items.Add(ad);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
        }



        private void listBoxTarifler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTarifler.SelectedIndex;
            if (index >= 0 && index < tarifler.Count)
            {
                var secilen = tarifler[index];
                labelMalzemeler.Text = "Malzemeler:\n" + secilen.Icerik;
                labelTarif.Text = "Yapılış:\n" + secilen.Yapilis;
            }
        }
    }
}
