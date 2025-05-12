using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaYonetim
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Uygulamanın görsel stilini etkinleştirir
            Application.EnableVisualStyles();

            // Uygulama için varsayılan yazı tipi ve diğer ayarları uygular
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1 adlı ana formu başlatır
            Application.Run(new Form1());
        }
    }
}