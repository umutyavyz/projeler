﻿using System;
using System.Windows.Forms;

namespace EtkinlikBiletSistemi
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana giriş noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisForm()); // İlk açılacak form Giriş ekranı
        }
    }
}
