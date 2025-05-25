using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asitakip
{
    public partial class Form3: Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            Kayit.ColumnCount = 10;
            Kayit.Columns[0].Name = "Tc kimlik";
            Kayit.Columns[1].Name = "Ad";
            Kayit.Columns[2].Name = "Soyadı";
            Kayit.Columns[3].Name = "Anne Adı";
            Kayit.Columns[4].Name = "Baba Adı";
            Kayit.Columns[5].Name = "Cinsiyet";
            Kayit.Columns[6].Name = "Doğum tarihi";
            Kayit.Columns[7].Name = "Aşı Tarihi";
            Kayit.Columns[8].Name = "Aşı Adı";
            Kayit.Columns[9].Name = "Dozu";

            

        }
        public void KayıtEkle(string tc, string adi, string soyadi, string anneadi, string babaadi, string cinsiyet, string dtarih, string atarih, string asiadi, string dozu)
        {
            Kayit.Rows.Add(tc,adi,soyadi,anneadi,babaadi,cinsiyet,dtarih,atarih,asiadi,dozu);
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            
            // Seçilen satırı kontrol et
            if (Kayit.SelectedRows.Count > 0)
            {
                // Seçilen satırları sil
                foreach (DataGridViewRow row in Kayit.SelectedRows)
                {
                    // Satır silme işlemi
                    if (!row.IsNewRow) // Yeni bir satır değilse
                    {
                        Kayit.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Silmek için bir satır seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        public DataGridView KayitProperty
        {
            get { return this.Kayit; }  // ya da this.dataGridView1
        }

       


    }
}


