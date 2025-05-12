using System;
using System.Windows.Forms;
using YemekTarifleriUygulmaü;

namespace YemekTarifleriUygulamasi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktasıdır.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Windows görsel temalarını aktif hale getirir
            Application.EnableVisualStyles();

            // Eski yazı tipi işleme yöntemini kapatır (daha yeni render)
            Application.SetCompatibleTextRenderingDefault(false);

            // Uygulama başladığında ilk açılacak form: Form1
            Application.Run(new Form1());
        }
    }
}
