namespace TakipSistemi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDersAdi = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dtpTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.rtbOdevKonusu = new System.Windows.Forms.RichTextBox();
            this.txtOdevBaslik = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvOdevler = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdevler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ödevin hangi derse ait olduğunu seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ödev başlığını kısaca yazınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ödev konusunu kısaca açıklayınız:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ödevin son teslim tarihini seçiniz:";
            // 
            // cmbDersAdi
            // 
            this.cmbDersAdi.FormattingEnabled = true;
            this.cmbDersAdi.Items.AddRange(new object[] {
            "Görsel Programlama Uygulamaları",
            "Mobil Programlama Uygulamaları",
            "İnternet Programlama Uygulamaları",
            "Java Programlama",
            "Mesleki Yabancı Dil (İngilizce)",
            "Yapay Zeka",
            "Yazılım Testi ",
            "Bitirme Projesi",
            "Dart Programlama Dili",
            "Kalite Güvence ve Standartları",
            "İş Ahlakı, Motivasyon ve Stres Yönetimi"});
            this.cmbDersAdi.Location = new System.Drawing.Point(225, 5);
            this.cmbDersAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDersAdi.Name = "cmbDersAdi";
            this.cmbDersAdi.Size = new System.Drawing.Size(181, 21);
            this.cmbDersAdi.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(225, 141);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(121, 19);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ödevİ Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dtpTeslimTarihi
            // 
            this.dtpTeslimTarihi.Location = new System.Drawing.Point(225, 119);
            this.dtpTeslimTarihi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            this.dtpTeslimTarihi.Size = new System.Drawing.Size(181, 20);
            this.dtpTeslimTarihi.TabIndex = 6;
            // 
            // rtbOdevKonusu
            // 
            this.rtbOdevKonusu.Location = new System.Drawing.Point(225, 57);
            this.rtbOdevKonusu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtbOdevKonusu.Name = "rtbOdevKonusu";
            this.rtbOdevKonusu.Size = new System.Drawing.Size(282, 58);
            this.rtbOdevKonusu.TabIndex = 7;
            this.rtbOdevKonusu.Text = "";
            // 
            // txtOdevBaslik
            // 
            this.txtOdevBaslik.Location = new System.Drawing.Point(225, 32);
            this.txtOdevBaslik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOdevBaslik.Name = "txtOdevBaslik";
            this.txtOdevBaslik.Size = new System.Drawing.Size(181, 20);
            this.txtOdevBaslik.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtOdevBaslik);
            this.panel1.Controls.Add(this.cmbDersAdi);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.dtpTeslimTarihi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.rtbOdevKonusu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 240);
            this.panel1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Honeydew;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(400, -2);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ÖDEV EKLEME/SİLME/LİSTELEME";
            // 
            // dgvOdevler
            // 
            this.dgvOdevler.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvOdevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdevler.Location = new System.Drawing.Point(12, 13);
            this.dgvOdevler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOdevler.Name = "dgvOdevler";
            this.dgvOdevler.RowHeadersWidth = 51;
            this.dgvOdevler.RowTemplate.Height = 24;
            this.dgvOdevler.Size = new System.Drawing.Size(872, 136);
            this.dgvOdevler.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 164);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 20);
            this.button2.TabIndex = 10;
            this.button2.Text = "Ödevi Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(446, 161);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 24);
            this.button3.TabIndex = 11;
            this.button3.Text = "Ödevi Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Controls.Add(this.dgvOdevler);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(9, 283);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 215);
            this.panel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(983, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "OdevTakipSistemi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdevler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDersAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DateTimePicker dtpTeslimTarihi;
        private System.Windows.Forms.RichTextBox rtbOdevKonusu;
        private System.Windows.Forms.TextBox txtOdevBaslik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvOdevler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
    }
}

