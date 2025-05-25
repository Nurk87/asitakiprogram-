using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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

        private void ekle_Click(object sender, EventArgs e)
        {
            string cinsiyet = kiz.Checked ? "Kız" : erkek.Checked ? "Erkek" : "Belirsiz";
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();


            // veriyi gönderme 
            form3.KayıtEkle(
                tcc.Text,
                adi.Text,
                soyadi.Text,
                anneadi.Text,
                babaadi.Text,
                cinsiyet,
                dtarihh.Text,
                atarihh.Text,
                asiadi.Text,
                doz.Text
                );

            // Temizle
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
    }
}
