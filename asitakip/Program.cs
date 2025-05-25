using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asitakip
{
    public class Kayit
    {
        public string Tc { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }
        public string Cinsiyet { get; set; }
        public string DogumTarihi { get; set; }
        public string AsiTarihi { get; set; }
        public string AsiAdi { get; set; }
        public string Doz { get; set; }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}