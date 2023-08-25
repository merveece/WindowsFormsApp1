using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.controller;
using WindowsFormsApp1.enumaration;
using WindowsFormsApp1.model;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result= controller.login(txt_kullaniciAdi.Text, txt_sifre.Text);

            if(result!=null && result.status==LoginStatus.basarili && result.yetki == "admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else if(result!=null && result.status==LoginStatus.basarili && result.yetki == "kasiyer")
            {
                KasiyerPanel kasiyer = new KasiyerPanel();
                kasiyer.Show();
                this.Hide();
            }
            else if(result!=null && result.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatası", "Hata!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Eksik Parametre Hatası", "Uyarı!", MessageBoxButtons.OK);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            SifreDegistirme SD = new SifreDegistirme();
            SD.Show();
            this.Hide();
        }
    }
}
