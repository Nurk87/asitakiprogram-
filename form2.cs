using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace asitakip
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saat.Text = DateTime.Now.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
           
        }
        public static List<Kayit> asiliste = new List<Kayit>();
        private void ekle_Click(object sender, EventArgs e)
        {
            string cinsiyet = kiz.Checked ? "Kız" : erkek.Checked ? "Erkek" : "Belirsiz";

            Kayit yeniKayit = new Kayit
            {
                Tc = tcc.Text,
                Adi = adi.Text,
                Soyadi = soyadi.Text,
                AnneAdi = anneadi.Text,
                BabaAdi = babaadi.Text,
                Cinsiyet = cinsiyet,
                DogumTarihi = dtarihh.Text,
                AsiTarihi = atarihh.Text,
                AsiAdi = asiadi.Text,
                Doz = doz.Text
            };

            // JSON dosyasına kaydet
            JsonVeriIslemleri.Ekle(yeniKayit);

            // Form3 açılırken kayıtları yükleyecek, burada sadece açıyoruz.
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();

            // Temizle (formu hazırla)
            tcc.Clear();
            adi.Clear();
            soyadi.Clear();
            anneadi.Clear();
            babaadi.Clear();
            kiz.Checked = false;
            erkek.Checked = false;
            asiadi.SelectedIndex = -1;
            doz.SelectedIndex = -1;
        }
        public static class JsonVeriIslemleri
        {
            private static string dosyaYolu = "veriler.json";

            public static List<Kayit> Oku()
            {
                if (!File.Exists(dosyaYolu))
                    return new List<Kayit>();

                string json = File.ReadAllText(dosyaYolu);
                return JsonConvert.DeserializeObject<List<Kayit>>(json) ?? new List<Kayit>();
            }

            public static void Kaydet(List<Kayit> kayitlar)
            {
                string json = JsonConvert.SerializeObject(kayitlar, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(dosyaYolu, json);
            }

            public static void Ekle(Kayit yeniKayit)
            {
                List<Kayit> mevcutlar = Oku();
                mevcutlar.Add(yeniKayit);
                Kaydet(mevcutlar);
            }
        }


        private void tcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textbox sadece sayı için kullanmak
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void gekran_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
