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
    public partial class SansiniDene : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public int sayi, puan, tutulansayi = 0, bakiye, atmdekipara, iban;
        public string sansinidenekazandiniz, sansinidenebasarisiz, sansinidenesayisec, sansinidenekaybettiniz, isim, soyisim, miktar;

        public SansiniDene()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime tarih = new DateTime();
            tarih = DateTime.Now;
            con.Open();
            SqlCommand islemekle = new SqlCommand("insert into islem(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
            islemekle.Parameters.AddWithValue("@miban", iban);
            islemekle.Parameters.AddWithValue("@isim", isim);
            islemekle.Parameters.AddWithValue("@soyisim", soyisim);
            islemekle.Parameters.AddWithValue("@yapilanislem", "Şansını Dene");
            islemekle.Parameters.AddWithValue("@miktar", "20");
            islemekle.Parameters.AddWithValue("@tarih", tarih);
            islemekle.ExecuteNonQuery();

            SqlCommand islemekleENG = new SqlCommand("insert into islemEng(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
            islemekleENG.Parameters.AddWithValue("@miban", iban);
            islemekleENG.Parameters.AddWithValue("@isim", isim);
            islemekleENG.Parameters.AddWithValue("@soyisim", soyisim);
            islemekleENG.Parameters.AddWithValue("@yapilanislem", "Try Your Chance");
            islemekleENG.Parameters.AddWithValue("@miktar", "20");
            islemekleENG.Parameters.AddWithValue("@tarih", tarih);
            islemekleENG.ExecuteNonQuery();
            con.Close();

            if (radioButton1.Checked)
                tutulansayi = 1;
            else if (radioButton2.Checked)
                tutulansayi = 2;
            else if (radioButton3.Checked)
                tutulansayi = 3;
            else if (radioButton4.Checked)
                tutulansayi = 4;
            else if (radioButton5.Checked)
                tutulansayi = 5;
            else if (radioButton6.Checked)
                tutulansayi = 6;
            else if (radioButton7.Checked)
                tutulansayi = 7;
            else if (radioButton8.Checked)
                tutulansayi = 8;
            else if (radioButton9.Checked)
                tutulansayi = 9;
            else if (radioButton10.Checked)
                tutulansayi = 10;
            else
                MessageBox.Show(sansinidenesayisec);

            Form kullaniciekrani = new KullaniciEkran();

            if (tutulansayi == sayi)
            {
                MessageBox.Show(String.Format(Localization.sansinidenekazandiniz, tutulansayi, sayi));
                puan = puan + 220;

                string kullaniciAdi = Giris.kullaniciAdi;
                string referanskodu = ReferansGiris.referanskodu;

                con.Open();
                SqlCommand Puan = new SqlCommand("update musteri set m_puan = '" + puan + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
                Puan.Connection = con;
                SqlDataReader dr2 = Puan.ExecuteReader();

                if (dr2.Read())
                {
                    MessageBox.Show(sansinidenebasarisiz);
                }

                else
                {
                    while (dr2.Read())
                    {
                        puan = Convert.ToInt32(dr2[9].ToString());
                    }
                    dr2.Close();
                    con.Close();
                }


                this.Hide();
                kullaniciekrani.Show();
            }

            else
            {
                MessageBox.Show(String.Format(Localization.sansinidenekaybettiniz, tutulansayi, sayi));
                this.Hide();
                kullaniciekrani.Show();
            }


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

            sansinidenekazandiniz = Localization.sansinidenekazandiniz;
            sansinidenebasarisiz = Localization.sansinidenebasarisiz;
            sansinidenesayisec = Localization.sansinidenesayisec;
            sansinidenekaybettiniz = Localization.sansinidenekaybettiniz;
            this.Text = Localization.SansiniDene;
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

        private void pb_resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
        }

        private void SansiniDene_Load(object sender, EventArgs e)
        {
            metinYazdir();

            Random rnd = new Random();
            sayi = rnd.Next(1,11);


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
                puan = Convert.ToInt32(dr[9].ToString());
                puan = puan - 20;
                iban = Convert.ToInt32(dr[0].ToString());
                isim = dr[4].ToString();
                soyisim = dr[5].ToString();

            }

            dr.Close();
            con.Close();

            con.Open();
            SqlCommand Puan = new SqlCommand("update musteri set m_puan = '" + puan + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            Puan.Connection = con;
            SqlDataReader dr2 = Puan.ExecuteReader();

            if (dr2.Read())
            {
                MessageBox.Show(sansinidenebasarisiz);
            }

            else
            {
                while (dr2.Read())
                {
                    puan = Convert.ToInt32(dr2[9].ToString());
                }
                dr2.Close();
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
