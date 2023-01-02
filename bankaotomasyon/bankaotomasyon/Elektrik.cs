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
    public partial class Elektrik : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public int bakiye, fatura, puan, atmdekipara, iban;
        public string isim, soyisim, miktar, faturabasarisiz, faturabasarili;

        private void pb_resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = Giris.kullaniciAdi;
            string referanskodu = ReferansGiris.referanskodu;

            int puanmiktar,cashback;

            atmdekipara = atmdekipara + fatura;
            bakiye = bakiye - fatura;
            bakiye = bakiye + (fatura / 20);
            cashback = fatura / 20;
            puan = puan + (fatura * 3 / 20);
            puanmiktar = fatura * 3 / 20;

            con.Open();
            SqlCommand faturaode = new SqlCommand("update musteri set m_bakiye = '" + bakiye + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            SqlCommand Fatura = new SqlCommand("update musteri set elektrik = '0' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            SqlCommand Puan = new SqlCommand("update musteri set m_puan = '" + puan + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            SqlCommand atmdekiPara = new SqlCommand("update sistem set atmpara = '" + atmdekipara + "'");

            faturaode.Connection = con;
            SqlDataReader dr = faturaode.ExecuteReader();

            if (dr.Read())

                MessageBox.Show(faturabasarisiz);


            else
            {
                while (dr.Read())
                {
                    bakiye = Convert.ToInt32(dr[8].ToString());
                }
                dr.Close();
                con.Close();

                con.Open();
                Fatura.Connection = con;
                SqlDataReader dr2 = Fatura.ExecuteReader();

                if (dr2.Read())
                {
                    MessageBox.Show(faturabasarisiz);
                }

                else
                {
                    while (dr2.Read())
                    {
                        fatura = Convert.ToInt32(dr2[12].ToString());
                    }

                    dr2.Close();
                    con.Close();

                    con.Open();
                    Puan.Connection = con;
                    SqlDataReader dr3 = Puan.ExecuteReader();

                    if (dr3.Read())
                    {
                        MessageBox.Show(faturabasarisiz);
                    }

                    else
                    {
                        while (dr3.Read())
                        {
                            puan = Convert.ToInt32(dr3[9].ToString());
                        }
                        dr3.Close();
                        con.Close();

                        con.Open();
                        atmdekiPara.Connection = con;
                        SqlDataReader dr4 = atmdekiPara.ExecuteReader();

                        if (dr4.Read())
                        {
                            MessageBox.Show(faturabasarisiz);
                        }

                        else
                        {
                            while (dr4.Read())
                            {
                                atmdekipara = Convert.ToInt32(dr4[1].ToString());
                            }

                            dr4.Close();

                            //islem tablosuna ekleme
                            DateTime tarih = new DateTime();
                            tarih = DateTime.Now;

                            SqlCommand islemekle = new SqlCommand("insert into islem(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                            islemekle.Parameters.AddWithValue("@miban", iban);
                            islemekle.Parameters.AddWithValue("@isim", isim);
                            islemekle.Parameters.AddWithValue("@soyisim", soyisim);
                            islemekle.Parameters.AddWithValue("@yapilanislem", "Ödeme: Elektrik Faturası");
                            islemekle.Parameters.AddWithValue("@miktar", miktar);
                            islemekle.Parameters.AddWithValue("@tarih", tarih);
                            islemekle.ExecuteNonQuery();

                            SqlCommand islemekleENG = new SqlCommand("insert into islemEng(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                            islemekleENG.Parameters.AddWithValue("@miban", iban);
                            islemekleENG.Parameters.AddWithValue("@isim", isim);
                            islemekleENG.Parameters.AddWithValue("@soyisim", soyisim);
                            islemekleENG.Parameters.AddWithValue("@yapilanislem", "Payment: Electricity");
                            islemekleENG.Parameters.AddWithValue("@miktar", miktar);
                            islemekleENG.Parameters.AddWithValue("@tarih", tarih);
                            islemekleENG.ExecuteNonQuery();

                            con.Close();
                        }

                    }

                    //parametreli localization
                    MessageBox.Show(String.Format(Localization.FaturaBasarili, puanmiktar, cashback));

                    this.Hide();
                    Form kullaniciekrani = new KullaniciEkran();
                    kullaniciekrani.Show();
                }
            }
        }

        public Elektrik()
        {
            InitializeComponent();
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

            lbl_odenecektutar.Text = Localization.lbl_odenecektutar;
            lbl_faturamesaj.Text = Localization.lbl_faturamesaj;
            btn_faturaode.Text = Localization.btn_faturaode;
            this.Text = Localization.Elektrik;
            faturabasarili = Localization.FaturaBasarili;
            faturabasarisiz = Localization.FaturaBasarisiz;

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

        private void Elektrik_Load(object sender, EventArgs e)
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
            com2 = new SqlCommand("select * from musteri where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com2.Connection = con;
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                fatura = Convert.ToInt32(dr2[12].ToString());

            }

            dr2.Close();
            con.Close();

            miktar = fatura.ToString();
            lbl_tutar.Text = "" + fatura + " ₺";


            SqlCommand com3 = new SqlCommand();
            con.Open();
            com3 = new SqlCommand("select * from musteri where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com3.Connection = con;
            SqlDataReader dr3 = com3.ExecuteReader();
            while (dr3.Read())
            {
                puan = Convert.ToInt32(dr3[9].ToString());

            }

            dr3.Close();
            con.Close();


            SqlCommand com4 = new SqlCommand();
            con.Open();
            com4 = new SqlCommand("select * from sistem");
            com4.Connection = con;
            SqlDataReader dr4 = com4.ExecuteReader();
            while (dr4.Read())
            {
                atmdekipara = Convert.ToInt32(dr4[1].ToString());

            }

            dr4.Close();
            con.Close();

            SqlCommand com5 = new SqlCommand();
            con.Open();
            com5 = new SqlCommand("select * from musteri where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com5.Connection = con;
            SqlDataReader dr5 = com5.ExecuteReader();
            while (dr5.Read())
            {
                iban = Convert.ToInt32(dr5[0].ToString());
                isim = dr5[4].ToString();
                soyisim = dr5[5].ToString();
            }

            dr5.Close();
            con.Close();


        }
    }
}
