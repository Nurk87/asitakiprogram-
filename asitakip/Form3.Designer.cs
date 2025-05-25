using System;

namespace asitakip
{
    public class Kayit
    {
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }
        public string AsiTuru { get; set; }
    }

    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Kayit = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Kayit)).BeginInit();
            this.SuspendLayout();
            // 
            // Kayit
            // 
            this.Kayit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Kayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kayit.Location = new System.Drawing.Point(0, -1);
            this.Kayit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kayit.Name = "Kayit";
            this.Kayit.RowHeadersWidth = 51;
            this.Kayit.RowTemplate.Height = 24;
            this.Kayit.Size = new System.Drawing.Size(1314, 475);
            this.Kayit.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "SİL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.sil_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(529, 494);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 27;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.cikis_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "GİRİŞ EKRANI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(225, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 44);
            this.button4.TabIndex = 29;
            this.button4.Text = "BİLGİ GİRİŞ EKRANI";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 559);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Kayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kayit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Kayit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}