using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.controller;
using WindowsFormsApp1.enumaration;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class SifreDegistirme : Form
    {
        int code;
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void SifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTable> loginTableList= controller.getLoginTable();

            grpBox_mailAlanı.Enabled = false;
            grpbox_sifreDegistirmeAlani.Enabled = false;

            foreach (LoginTable lt in loginTableList)
            {
                combobox_guvenlikSorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
        }

        private void buttonSorgula1_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result= controller.doAuthentication(txt_kullaniciAdi.Text.Trim().ToLower(),combobox_guvenlikSorusu.SelectedItem.ToString(),txt_guvenlikCevabi.Text.ToLower());
            if (result == LoginStatus.basarili)
                grpBox_mailAlanı.Enabled = true;
            else if (result == LoginStatus.basarisiz)
                MessageBox.Show("Girdiğiniz Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Tüm Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btn_dogrulamaGonder_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            string emailAdres= controller.CheckEmailAddress(txt_kullaniciAdi.Text);

            if (emailAdres == txt_emailAdres.Text)
            {
                Random rnd = new Random();
                code = rnd.Next(11111, 999999);

                MailAddress mailAlan = new MailAddress(txt_emailAdres.Text, txt_kullaniciAdi.Text);
                MailAddress mailGonderen = new MailAddress("merveasici1905@gmail.com", "Merve");

                MailMessage mesaj = new MailMessage();

                mesaj.To.Add(mailAlan);
                mesaj.From = mailGonderen;
                mesaj.Subject = "Şifre Değiştirme";
                mesaj.Body = "Şifrenizi Değiştirmek İçin Doğrulama Kodunuz :" + code;

                SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("merveasici1905@gmail.com", "17704796450");
                smtp.EnableSsl = true;
                smtp.Send(mesaj);
                MessageBox.Show("Doğrulama Kodu Gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Hesabınıza bağlı Mail adresini giriniz!","Uyarı",MessageBoxButtons.OK);
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            if (txt_dogrulamaKodu.Text == code.ToString())
            {
                grpbox_sifreDegistirmeAlani.Enabled = true;

            }
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();

            if (txt_yeniSifre.Text == txt_yeniSifreTekrar.Text)
            {
                LoginStatus result = controller.changePassword(txt_kullaniciAdi.Text, txt_yeniSifre.Text);
                if (result == LoginStatus.basarili)
                    MessageBox.Show("Şifreniz Değiştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Gerekli alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Girilen şifreleri farklı girdiniz!", "Hata", MessageBoxButtons.OK);


            controller.changePassword(txt_kullaniciAdi.Text,txt_yeniSifre.Text);
        }
    }
}
