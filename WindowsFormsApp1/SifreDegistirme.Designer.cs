
namespace WindowsFormsApp1
{
    partial class SifreDegistirme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.combobox_guvenlikSorusu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_guvenlikCevabi = new System.Windows.Forms.TextBox();
            this.buttonSorgula1 = new System.Windows.Forms.Button();
            this.grpbox_sifreDegistirmeAlani = new System.Windows.Forms.GroupBox();
            this.txt_yeniSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_degistir = new System.Windows.Forms.Button();
            this.grpBox_mailAlanı = new System.Windows.Forms.GroupBox();
            this.txt_emailAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_dogrulamaGonder = new System.Windows.Forms.Button();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.txt_dogrulamaKodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbox_sifreDegistirmeAlani.SuspendLayout();
            this.grpBox_mailAlanı.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSorgula1);
            this.groupBox1.Controls.Add(this.combobox_guvenlikSorusu);
            this.groupBox1.Controls.Add(this.txt_guvenlikCevabi);
            this.groupBox1.Controls.Add(this.txt_kullaniciAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 214);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik Sorusu İle Değiştir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(133, 37);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(145, 22);
            this.txt_kullaniciAdi.TabIndex = 1;
            // 
            // combobox_guvenlikSorusu
            // 
            this.combobox_guvenlikSorusu.FormattingEnabled = true;
            this.combobox_guvenlikSorusu.Location = new System.Drawing.Point(133, 73);
            this.combobox_guvenlikSorusu.Name = "combobox_guvenlikSorusu";
            this.combobox_guvenlikSorusu.Size = new System.Drawing.Size(145, 24);
            this.combobox_guvenlikSorusu.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı:";
            // 
            // txt_guvenlikCevabi
            // 
            this.txt_guvenlikCevabi.Location = new System.Drawing.Point(133, 112);
            this.txt_guvenlikCevabi.Name = "txt_guvenlikCevabi";
            this.txt_guvenlikCevabi.Size = new System.Drawing.Size(145, 22);
            this.txt_guvenlikCevabi.TabIndex = 1;
            // 
            // buttonSorgula1
            // 
            this.buttonSorgula1.Location = new System.Drawing.Point(10, 153);
            this.buttonSorgula1.Name = "buttonSorgula1";
            this.buttonSorgula1.Size = new System.Drawing.Size(244, 33);
            this.buttonSorgula1.TabIndex = 2;
            this.buttonSorgula1.Text = "Sorgula";
            this.buttonSorgula1.UseVisualStyleBackColor = true;
            this.buttonSorgula1.Click += new System.EventHandler(this.buttonSorgula1_Click);
            // 
            // grpbox_sifreDegistirmeAlani
            // 
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.btn_degistir);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifreTekrar);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.label5);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.txt_yeniSifre);
            this.grpbox_sifreDegistirmeAlani.Controls.Add(this.label4);
            this.grpbox_sifreDegistirmeAlani.Location = new System.Drawing.Point(380, 266);
            this.grpbox_sifreDegistirmeAlani.Name = "grpbox_sifreDegistirmeAlani";
            this.grpbox_sifreDegistirmeAlani.Size = new System.Drawing.Size(299, 193);
            this.grpbox_sifreDegistirmeAlani.TabIndex = 4;
            this.grpbox_sifreDegistirmeAlani.TabStop = false;
            this.grpbox_sifreDegistirmeAlani.Text = "Şifre Değiştir";
            // 
            // txt_yeniSifre
            // 
            this.txt_yeniSifre.Location = new System.Drawing.Point(123, 47);
            this.txt_yeniSifre.Name = "txt_yeniSifre";
            this.txt_yeniSifre.Size = new System.Drawing.Size(162, 22);
            this.txt_yeniSifre.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yeni Şifre:";
            // 
            // txt_yeniSifreTekrar
            // 
            this.txt_yeniSifreTekrar.Location = new System.Drawing.Point(122, 84);
            this.txt_yeniSifreTekrar.Name = "txt_yeniSifreTekrar";
            this.txt_yeniSifreTekrar.Size = new System.Drawing.Size(162, 22);
            this.txt_yeniSifreTekrar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yeni Şifre Tekrar:";
            // 
            // btn_degistir
            // 
            this.btn_degistir.Location = new System.Drawing.Point(176, 127);
            this.btn_degistir.Name = "btn_degistir";
            this.btn_degistir.Size = new System.Drawing.Size(117, 33);
            this.btn_degistir.TabIndex = 2;
            this.btn_degistir.Text = "Değiştir";
            this.btn_degistir.UseVisualStyleBackColor = true;
            this.btn_degistir.Click += new System.EventHandler(this.btn_degistir_Click);
            // 
            // grpBox_mailAlanı
            // 
            this.grpBox_mailAlanı.Controls.Add(this.btn_onayla);
            this.grpBox_mailAlanı.Controls.Add(this.txt_dogrulamaKodu);
            this.grpBox_mailAlanı.Controls.Add(this.label7);
            this.grpBox_mailAlanı.Controls.Add(this.btn_dogrulamaGonder);
            this.grpBox_mailAlanı.Controls.Add(this.txt_emailAdres);
            this.grpBox_mailAlanı.Controls.Add(this.label6);
            this.grpBox_mailAlanı.Location = new System.Drawing.Point(380, 28);
            this.grpBox_mailAlanı.Name = "grpBox_mailAlanı";
            this.grpBox_mailAlanı.Size = new System.Drawing.Size(299, 214);
            this.grpBox_mailAlanı.TabIndex = 1;
            this.grpBox_mailAlanı.TabStop = false;
            this.grpBox_mailAlanı.Text = "Mail İle Değiştir";
            // 
            // txt_emailAdres
            // 
            this.txt_emailAdres.Location = new System.Drawing.Point(144, 28);
            this.txt_emailAdres.Name = "txt_emailAdres";
            this.txt_emailAdres.Size = new System.Drawing.Size(142, 22);
            this.txt_emailAdres.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email Adresiniz:";
            // 
            // btn_dogrulamaGonder
            // 
            this.btn_dogrulamaGonder.Location = new System.Drawing.Point(85, 64);
            this.btn_dogrulamaGonder.Name = "btn_dogrulamaGonder";
            this.btn_dogrulamaGonder.Size = new System.Drawing.Size(180, 33);
            this.btn_dogrulamaGonder.TabIndex = 4;
            this.btn_dogrulamaGonder.Text = "Doğrulama Kodu Gönder";
            this.btn_dogrulamaGonder.UseVisualStyleBackColor = true;
            this.btn_dogrulamaGonder.Click += new System.EventHandler(this.btn_dogrulamaGonder_Click);
            // 
            // btn_onayla
            // 
            this.btn_onayla.Location = new System.Drawing.Point(144, 167);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(121, 30);
            this.btn_onayla.TabIndex = 7;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // txt_dogrulamaKodu
            // 
            this.txt_dogrulamaKodu.Location = new System.Drawing.Point(142, 127);
            this.txt_dogrulamaKodu.Name = "txt_dogrulamaKodu";
            this.txt_dogrulamaKodu.Size = new System.Drawing.Size(142, 22);
            this.txt_dogrulamaKodu.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Doğrulama Kodu:";
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 471);
            this.Controls.Add(this.grpbox_sifreDegistirmeAlani);
            this.Controls.Add(this.grpBox_mailAlanı);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirme";
            this.Load += new System.EventHandler(this.SifreDegistirme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_sifreDegistirmeAlani.ResumeLayout(false);
            this.grpbox_sifreDegistirmeAlani.PerformLayout();
            this.grpBox_mailAlanı.ResumeLayout(false);
            this.grpBox_mailAlanı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpbox_sifreDegistirmeAlani;
        private System.Windows.Forms.Button btn_degistir;
        private System.Windows.Forms.TextBox txt_yeniSifreTekrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_yeniSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSorgula1;
        private System.Windows.Forms.ComboBox combobox_guvenlikSorusu;
        private System.Windows.Forms.TextBox txt_guvenlikCevabi;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBox_mailAlanı;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.TextBox txt_dogrulamaKodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_dogrulamaGonder;
        private System.Windows.Forms.TextBox txt_emailAdres;
        private System.Windows.Forms.Label label6;
    }
}