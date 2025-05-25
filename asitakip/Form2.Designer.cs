using System;

namespace asitakip
{
    
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.kiz = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtarihh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.atarihh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.asiadi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.doz = new System.Windows.Forms.ComboBox();
            this.ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.anneadi = new System.Windows.Forms.TextBox();
            this.babaadi = new System.Windows.Forms.TextBox();
            this.saat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADI:";
            // 
            // adi
            // 
            this.adi.Location = new System.Drawing.Point(141, 32);
            this.adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(177, 22);
            this.adi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYADI:";
            // 
            // soyadi
            // 
            this.soyadi.Location = new System.Drawing.Point(141, 70);
            this.soyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(177, 22);
            this.soyadi.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "T.C. KİMLİK:";
            // 
            // tcc
            // 
            this.tcc.Location = new System.Drawing.Point(141, 108);
            this.tcc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tcc.Name = "tcc";
            this.tcc.Size = new System.Drawing.Size(236, 22);
            this.tcc.TabIndex = 7;
            this.tcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcc_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CİNSİYET:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.erkek);
            this.groupBox1.Controls.Add(this.kiz);
            this.groupBox1.Location = new System.Drawing.Point(141, 150);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(245, 44);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(107, 18);
            this.erkek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(72, 20);
            this.erkek.TabIndex = 1;
            this.erkek.TabStop = true;
            this.erkek.Text = "ERKEK";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // kiz
            // 
            this.kiz.AutoSize = true;
            this.kiz.Location = new System.Drawing.Point(13, 18);
            this.kiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kiz.Name = "kiz";
            this.kiz.Size = new System.Drawing.Size(47, 20);
            this.kiz.TabIndex = 0;
            this.kiz.TabStop = true;
            this.kiz.Text = "KIZ";
            this.kiz.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "DOĞUM TARİHİ:";
            // 
            // dtarihh
            // 
            this.dtarihh.Location = new System.Drawing.Point(141, 210);
            this.dtarihh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtarihh.Name = "dtarihh";
            this.dtarihh.Size = new System.Drawing.Size(200, 22);
            this.dtarihh.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "AŞI TARİHİ:";
            // 
            // atarihh
            // 
            this.atarihh.Location = new System.Drawing.Point(605, 206);
            this.atarihh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.atarihh.Name = "atarihh";
            this.atarihh.Size = new System.Drawing.Size(200, 22);
            this.atarihh.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "AŞI ADI:";
            // 
            // asiadi
            // 
            this.asiadi.FormattingEnabled = true;
            this.asiadi.Items.AddRange(new object[] {
            "Hepatit B ",
            "Verem ",
            "5\'li Karma",
            "Zatüre",
            "KKK(Kızamık kızamıkçık kabakulak)",
            "Suçiçeği ",
            "Çocuk Felci",
            "Hepatit A"});
            this.asiadi.Location = new System.Drawing.Point(141, 257);
            this.asiadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asiadi.Name = "asiadi";
            this.asiadi.Size = new System.Drawing.Size(179, 24);
            this.asiadi.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "DOZU:";
            // 
            // doz
            // 
            this.doz.FormattingEnabled = true;
            this.doz.Items.AddRange(new object[] {
            "1.Ay",
            "2.Ay",
            "4.Ay",
            "6.Ay",
            "12.Ay",
            "18.Ay",
            "1.Yaş",
            "2.Yaş"});
            this.doz.Location = new System.Drawing.Point(605, 260);
            this.doz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doz.Name = "doz";
            this.doz.Size = new System.Drawing.Size(121, 24);
            this.doz.TabIndex = 22;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(333, 329);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(111, 39);
            this.ekle.TabIndex = 23;
            this.ekle.Text = "KAYDET";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 329);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 39);
            this.button2.TabIndex = 25;
            this.button2.Text = "GİRİŞ EKRANI";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.gekran_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(880, 329);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 26;
            this.button3.Text = "ÇIKIŞ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.cikis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 27;
            this.label9.Text = "ANNE ADI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(521, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "BABA ADI:";
            // 
            // anneadi
            // 
            this.anneadi.Location = new System.Drawing.Point(605, 34);
            this.anneadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anneadi.Name = "anneadi";
            this.anneadi.Size = new System.Drawing.Size(100, 22);
            this.anneadi.TabIndex = 29;
            // 
            // babaadi
            // 
            this.babaadi.Location = new System.Drawing.Point(605, 76);
            this.babaadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.babaadi.Name = "babaadi";
            this.babaadi.Size = new System.Drawing.Size(100, 22);
            this.babaadi.TabIndex = 30;
            // 
            // saat
            // 
            this.saat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saat.Location = new System.Drawing.Point(0, 431);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(1118, 34);
            this.saat.TabIndex = 31;
            this.saat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1118, 465);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.babaadi);
            this.Controls.Add(this.anneadi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.doz);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.asiadi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.atarihh);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtarihh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AŞI TAKİP PROGRAMI";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.RadioButton kiz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtarihh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker atarihh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox asiadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox doz;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox anneadi;
        private System.Windows.Forms.TextBox babaadi;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer timer1;
    }
}