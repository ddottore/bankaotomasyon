﻿using System;
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
    public partial class ParaYatirma : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public ParaYatirma()
        {
            InitializeComponent();
        }

        public int bakiye, atmdekipara,iban;
        public string isim, soyisim,miktar, parayatirmabasarili, parayatirmabasarisiz;

        private void pb_resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
        }

        private void ParaYatirma_Load(object sender, EventArgs e)
        {
            metinYazdir();

            string kullaniciAdi = Giris.kullaniciAdi;
            string referanskodu = ReferansGiris.referanskodu;

            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com = new SqlCommand("select * from musteri where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                bakiye = Convert.ToInt32(dr[8].ToString());

            }

            dr.Close();
            con.Close();

            SqlCommand com2 = new SqlCommand();
            con.Open();
            com2 = new SqlCommand("select * from sistem");
            com2.Connection = con;
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                atmdekipara = Convert.ToInt32(dr2[1].ToString());

            }

            dr2.Close();
            con.Close();


            SqlCommand com3 = new SqlCommand();
            con.Open();
            com3 = new SqlCommand("select * from musteri where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com3.Connection = con;
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                iban = Convert.ToInt32(dr3[0].ToString());
                isim = dr3[4].ToString();
                soyisim = dr3[5].ToString();
            }

            dr3.Close();
            con.Close();
        }

        public void metinYazdir()
        {
            if (Settings.Default.lang == "English")
            {
                pb_resim.Image = Properties.Resources.turkey;
                Localization.Culture = new CultureInfo("en");
            }
            else if (Settings.Default.lang == "Turkish")
            {
                pb_resim.Image = Properties.Resources.icons8_great_britain_96;
                Localization.Culture = new CultureInfo("");
            }

            btnParayatir.Text = Localization.btnParayatir;
            lblYatiralacakTutar.Text = Localization.lblYatiralacakTutar;
            this.Text = Localization.ParaYatirma;
            parayatirmabasarisiz = Localization.ParayatirmaBasarisiz;
            parayatirmabasarili = Localization.ParayatirmaBasarili;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = Giris.kullaniciAdi;
            string referanskodu = ReferansGiris.referanskodu;

            int yenibakiye, eklenecektutar = Convert.ToInt32(txtParaYatir.Text);

            yenibakiye = bakiye + eklenecektutar;
            atmdekipara = atmdekipara + eklenecektutar;

            con.Open();
            SqlCommand parayatir = new SqlCommand("update musteri set m_bakiye = '" + yenibakiye + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            SqlCommand atmdekiPara = new SqlCommand("update sistem set atmpara = '" + atmdekipara + "'");

            parayatir.Connection = con;
            SqlDataReader dr = parayatir.ExecuteReader();

            if (dr.Read())

                MessageBox.Show(parayatirmabasarisiz);


            else
            {
                while (dr.Read())
                {
                    bakiye = Convert.ToInt32(dr[8].ToString());
                }
                dr.Close();
                con.Close();

                con.Open();
                atmdekiPara.Connection = con;
                SqlDataReader dr2 = atmdekiPara.ExecuteReader();

                if (dr2.Read())
                {
                    MessageBox.Show(parayatirmabasarisiz);
                }

                else
                {
                    while (dr2.Read())
                    {
                        atmdekipara = Convert.ToInt32(dr2[1].ToString());
                    }

                    dr2.Close();

                    //islem tablosuna ekleme
                    miktar = txtParaYatir.Text.ToString();
                    DateTime tarih = new DateTime();
                    tarih = DateTime.Now;

                    SqlCommand islemekle = new SqlCommand("insert into islem(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                    islemekle.Parameters.AddWithValue("@miban", iban);
                    islemekle.Parameters.AddWithValue("@isim", isim);
                    islemekle.Parameters.AddWithValue("@soyisim", soyisim);
                    islemekle.Parameters.AddWithValue("@yapilanislem", "Para Yatırma");
                    islemekle.Parameters.AddWithValue("@miktar", miktar);
                    islemekle.Parameters.AddWithValue("@tarih", tarih);
                    islemekle.ExecuteNonQuery();

                    SqlCommand islemekleENG = new SqlCommand("insert into islemEng(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                    islemekleENG.Parameters.AddWithValue("@miban", iban);
                    islemekleENG.Parameters.AddWithValue("@isim", isim);
                    islemekleENG.Parameters.AddWithValue("@soyisim", soyisim);
                    islemekleENG.Parameters.AddWithValue("@yapilanislem", "Deposit Money");
                    islemekleENG.Parameters.AddWithValue("@miktar", miktar);
                    islemekleENG.Parameters.AddWithValue("@tarih", tarih);
                    islemekleENG.ExecuteNonQuery();

                    MessageBox.Show(parayatirmabasarili);
                    
                    con.Close();
                    this.Hide();
                    Form kullaniciekrani = new KullaniciEkran();
                    kullaniciekrani.Show();
                }
            }

        }
    }
}
