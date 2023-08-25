using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MerveSebzePanel : Form
    {
        int sayi1;
        int sayi2;
        int islemTip;

        public MerveSebzePanel()
        {
            InitializeComponent();
        }

        private void secilenTus(object sender, EventArgs e)
        {
            if (txt_islem.Text == "0")
                txt_islem.Text = "";
            txt_islem.Text += ((Button)sender).Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_islem.Text = "0";
        }

        private void btn_topla_Click(object sender, EventArgs e)
        {
            islemTip = 1;
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (islemTip == 1)
            {
                sayi1 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 + sayi2).ToString();
            }
            else if (islemTip == 2)
            {
                sayi1 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 - sayi2).ToString();
            }
            else if (islemTip == 3)
            {
                sayi1 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }
            else
            {
                sayi1 = int.Parse(txt_islem.Text);
                txt_islem.Text = (sayi1 * sayi2).ToString();
            }

        }
        private void btn_carp_Click(object sender, EventArgs e)
            {
                islemTip = 3;
                sayi1 = int.Parse(txt_islem.Text);
                txt_islem.Text = "0";
            }

        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            islemTip = 3;
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_bol_Click(object sender, EventArgs e)
        {
            islemTip = 4;
            sayi1 = int.Parse(txt_islem.Text);
            txt_islem.Text = "0";
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            if (txt_islem.Text.Length != 0)
            {

                txt_islem.Text = txt_islem.Text.Substring(0, txt_islem.Text.Length - 1);
            }
            else
                txt_islem.Text = "0";
        }
    }
   }
