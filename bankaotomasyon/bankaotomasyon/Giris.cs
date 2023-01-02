using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Globalization;

namespace bankaotomasyon
{
    public partial class Giris : Form
    {
        public string kullanicihatali;
        SqlConnection con;
        SqlDataReader dr,dr2;
        SqlCommand com,com2;
        public Giris()
        {
            InitializeComponent();
            
        }

        public static string kullaniciAdi,kullaniciSifre;

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {

            //database bağlama//
            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            com = new SqlCommand();
            com2 = new SqlCommand();

            con.Open();

            com2.Connection = con;

            com.CommandText = "select*from musteri where kullaniciAdi = '" + txtKullaniciAdi.Text + "' and kullaniciSifre = '" + txtKullaniciSifre.Text + "' ";
            com2.CommandText = "select*from yonetici where yoneticikullaniciadi = '" + txtKullaniciAdi.Text + "' and yoneticisifre = '" + txtKullaniciSifre.Text + "' ";

            dr2 = com2.ExecuteReader();

            kullaniciAdi = txtKullaniciAdi.Text;
            kullaniciSifre = txtKullaniciSifre.Text;

            Form kullaniciekran = new KullaniciEkran();
            Form yoneticigirisi = new YoneticiGirisi();

            if (dr2.Read())
            {
                yoneticigirisi.Show();
                this.Hide();
            }
            else
            {
                con.Close();
                com.Connection = con;
                con.Open();
                dr = com.ExecuteReader();

                if (dr.Read())
                {
                    kullaniciekran.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show(kullanicihatali);
                }
                
                con.Close();
            }
        }

        public void metinYazdir()
        {
            if(Settings.Default.lang == "English")
            {
                pb_resim.Image = Properties.Resources.turkey;
                Localization.Culture = new CultureInfo("en");
            }
            else if (Settings.Default.lang == "Turkish")
            {
                pb_resim.Image = Properties.Resources.icons8_great_britain_96;
                Localization.Culture = new CultureInfo("");
            }

            btnGiris.Text = Localization.btnGiris;
            btnKayit.Text = Localization.btnKayit;
            btnReferans.Text = Localization.btnReferans;
            this.Text = Localization.Giris;
            kullanicihatali = Localization.KullaniciHatali;
        }

        public void resimGuncelle(PictureBox resim)
        {
            if (Settings.Default.lang == "Turkish")
            {
                resim.Image = Properties.Resources.turkey;
                resim.Refresh();
                resim.Visible = true;

                Settings.Default.lang = "English";
                Settings.Default.Save();
            }
            else if (Settings.Default.lang == "English")
            {
                resim.Image = Properties.Resources.icons8_great_britain_96;
                resim.Refresh();
                resim.Visible = true;

                Settings.Default.lang = "Turkish";
                Settings.Default.Save();
            }
            metinYazdir();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            metinYazdir();
        }

        private void Referansgiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form giris = new Giris();
            Form referansgiris = new ReferansGiris();
            referansgiris.Hide();
            giris.Show();
        }

        private void btnReferans_Click_1(object sender, EventArgs e)
        {
            Form referansgiris = new ReferansGiris();
            referansgiris.FormClosed += Referansgiris_FormClosed; //sekme kapatıldığında giriş ekranına atar//

            referansgiris.Show();
            this.Hide();
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            
            Form kayitekrani = new KayitEkrani();
            kayitekrani.FormClosed += Kayitekrani_FormClosed;
            
            kayitekrani.Show();
            this.Hide();
        }

        private void Kayitekrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form giris = new Giris();
            Form kayitekrani = new KayitEkrani();
           
            kayitekrani.Hide();
            giris.Show();
        }

        private void resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form yoneticigirisi = new YoneticiGirisi();
            yoneticigirisi.FormClosed += Yoneticigirisi_FormClosed;
            
            yoneticigirisi.Show();
            this.Hide();
        }

        private void Yoneticigirisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form giris = new Giris();
            Form yoneticigirisi = new YoneticiGirisi();

            yoneticigirisi.Hide();
            giris.Show();
        }
    }
}