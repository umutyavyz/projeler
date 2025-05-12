using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaYonetim
{
    public partial class Form1 : Form
    {
        // Form Yüklenirken film ve salon seçeneklerini ekliyoruz
        public Form1()
        {
            InitializeComponent();
            LoadFilmler();
            LoadBiletTipi();
            LoadSalonlar();
            comboBoxFilmler.SelectedIndexChanged += comboBoxFilmler_SelectedIndexChanged;
        }


        private bool filmlerYuklendi = false; // Veri yüklendi mi kontrolü


        private void LoadFilmler()
        {
            string query = "SELECT Id, FilmAdi FROM Filmler";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            // Placeholder (sahte) satır ekle
            DataRow placeholderRow = dt.NewRow();
            placeholderRow["Id"] = 0;
            placeholderRow["FilmAdi"] = "-- Film Seçiniz --";
            dt.Rows.InsertAt(placeholderRow, 0); // Listenin en başına ekle

            comboBoxFilmler.DisplayMember = "FilmAdi";
            comboBoxFilmler.ValueMember = "Id";
            comboBoxFilmler.DataSource = dt;

            filmlerYuklendi = true;
        }

        private void LoadBiletTipi()
        {
            comboBoxBiletTipi.Items.Add("Öğrenci");
            comboBoxBiletTipi.Items.Add("Yetişkin");
        }

        private void LoadSalonlar()
        {
            for (int i = 1; i <= 10; i++)
            {
                comboBoxSalon.Items.Add($"Salon {i}");
            }
        }

        // Film seçimi değiştiğinde poster gösterme
        private void comboBoxFilmler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!filmlerYuklendi || comboBoxFilmler.SelectedValue == null)
                return;

            if (int.TryParse(comboBoxFilmler.SelectedValue.ToString(), out int filmId))
            {
                string query = "SELECT ResimLink FROM Filmler WHERE Id = @id";
                var dt = DatabaseHelper.ExecuteQuery(query, new SqlParameter("@id", filmId));

                if (dt.Rows.Count > 0)
                {
                    string url = dt.Rows[0]["ResimLink"].ToString();
                    try
                    {
                        pictureBoxFilm.Load(url);
                        pictureBoxFilm.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    catch
                    {
                        pictureBoxFilm.Image = null;
                        MessageBox.Show("Resim yüklenemedi.");
                    }
                }
            }
        }

        // Bilet al butonuna tıklanınca yapılacak işlemler
        private void btnBiletAl_Click(object sender, EventArgs e)
        {
            if (comboBoxFilmler.SelectedValue == null || comboBoxFilmler.SelectedValue.ToString() == "0")
            {
                MessageBox.Show("Lütfen bir film seçiniz.");
                return;
            }

            var filmAdi = comboBoxFilmler.Text;
            var biletTipi = comboBoxBiletTipi.Text;
            var salon = comboBoxSalon.Text;
            int biletSayisi = (int)numericUpDownBiletSayisi.Value;

            if (string.IsNullOrWhiteSpace(biletTipi) || string.IsNullOrWhiteSpace(salon))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return;
            }

            if (biletSayisi <= 0)
            {
                MessageBox.Show("Lütfen en az 1 bilet seçiniz.");
                return;
            }

            string mesaj = $"Film: {filmAdi}\n" +
                           $"Bilet Tipi: {biletTipi}\n" +
                           $"Salon: {salon}\n" +
                           $"Bilet Sayısı: {biletSayisi}\n\n" +
                           $"Onaylıyor musunuz?";

            DialogResult result = MessageBox.Show(mesaj, "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Bilet alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxBiletTipi.Text = "Bilet Tipi Seçiniz...";
            comboBoxSalon.Text = "Salon Seçiniz...";

            numericUpDownBiletSayisi.Minimum = 1;
            numericUpDownBiletSayisi.Value = 1;
        }

        private void comboBoxBiletTipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
