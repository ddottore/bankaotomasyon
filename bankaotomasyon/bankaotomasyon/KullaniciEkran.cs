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
    public partial class KullaniciEkran : Form
    {
        public Giris giris;

        SqlConnection connect;
        SqlDataReader dr;
        SqlCommand com;

        public KullaniciEkran()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server =EMIR-PC\\SQLEXPRESS; Database = bankaotomasyon;Trusted_Connection= true");

        public string musteriad, musterisoyad, isim, soyisim, miktar, puancevirmebasarisiz, puancevirmebasarili;
        public int bakiye, puan, atmdekipara, iban;
        private void KullaniciEkran_Load(object sender, EventArgs e)
        {
            metinYazdir();

            string kullaniciAdi = Giris.kullaniciAdi;
            string referanskodu = ReferansGiris.referanskodu;

            connect = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            com = new SqlCommand();
            connect.Open();
            com = new SqlCommand("select * from musteri where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com.Connection = connect;
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                musteriad = dr[4].ToString();
                musterisoyad = dr[5].ToString();
                bakiye = Convert.ToInt32(dr[8].ToString());
                puan = Convert.ToInt32(dr[9].ToString());

            }

            dr.Close();
            connect.Close();

            lbl_musteriadsoyad.Text = "" + musteriad + " " + musterisoyad + "";
            lbl_bakiye.Text = "" + bakiye + " ₺";
            lbl_puan.Text = "" + puan + " eP";


            SqlCommand com2 = new SqlCommand();
            connect.Open();
            com2 = new SqlCommand("select * from sistem");
            com2.Connection = connect;
            SqlDataReader dr2 = com2.ExecuteReader();
            while (dr2.Read())
            {
                atmdekipara = Convert.ToInt32(dr2[1].ToString());

            }

            dr2.Close();
            connect.Close();

            lbl_atmdekipara.Text = "" + atmdekipara + " ₺";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form paracekme = new ParaCekme();
            paracekme.FormClosed += Paracekme_FormClosed;

            paracekme.Show();
            this.Hide();

        }

        private void Paracekme_FormClosed(object sender, FormClosedEventArgs e)
        {   
            Form paracekme = new ParaCekme();
            Form kullaniciekrani = new KullaniciEkran();

            paracekme.Hide();
            kullaniciekrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form parayatirma = new ParaYatirma();
            parayatirma.FormClosed += Parayatirma_FormClosed;

            parayatirma.Show();
            this.Hide();
        }

        private void Parayatirma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form parayatirma = new ParaYatirma();
            Form kullaniciekrani = new KullaniciEkran();

            parayatirma.Hide();
            kullaniciekrani.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form paratransfer = new ParaTransferi();
            paratransfer.FormClosed += Paratransfer_FormClosed;

            paratransfer.Show();
            this.Hide();
        }

        private void Paratransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form paratransfer = new ParaTransferi();
            Form kullaniciekrani = new KullaniciEkran();

            paratransfer.Hide();
            kullaniciekrani.Show();
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

            lbl_hosgeldiniz.Text = Localization.lbl_hosgeldiniz;
            label2.Text = Localization.label2;
            btn_paracek.Text = Localization.btn_paracek;
            btn_parayatir.Text = Localization.btn_parayatir;
            btn_paratransfer.Text = Localization.btn_paratransfer;
            btn_odeme.Text = Localization.btn_odeme;
            btn_puancevir.Text = Localization.btn_puancevir;
            btn_kAskidaPara.Text = Localization.btn_kAskidaPara;
            lbl_atmtoplampara.Text = Localization.lbl_atmtoplampara;
            label3.Text = Localization.label3;
            lbl_kAciklama.Text = Localization.lbl_kAciklama;
            btn_sansinidene.Text = Localization.btn_sansinidene;
            this.Text = Localization.KullaniciEkrani;
            puancevirmebasarisiz = Localization.puancevirmebasarisiz;
            puancevirmebasarili = Localization.puancevirmebasarili;

        }

        private void KullaniciEkran_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show(Localization.secim, Localization.cikis, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim == DialogResult.Yes)
            {
                Environment.Exit(0);
            }

            if (secim == DialogResult.No)
            {
                e.Cancel = true;
                MessageBox.Show(Localization.iptal, Localization.bilgilendirme, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
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
                puan = Convert.ToInt32(dr3[9].ToString());

            }

            dr3.Close();
            con.Close();


            int yenibakiye, eklenecektutar = puan;

            miktar = eklenecektutar.ToString();
            yenibakiye = bakiye + eklenecektutar;
            atmdekipara = atmdekipara + eklenecektutar;

            con.Open();
            SqlCommand parayatir = new SqlCommand("update musteri set m_bakiye = '" + yenibakiye + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            SqlCommand atmdekiPara = new SqlCommand("update sistem set atmpara = '" + atmdekipara + "'");
            SqlCommand Puan = new SqlCommand("update musteri set m_puan = '0' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");

            parayatir.Connection = con;
            SqlDataReader dr4 = parayatir.ExecuteReader();

            if (dr4.Read())

                MessageBox.Show(puancevirmebasarisiz);


            else
            {
                while (dr4.Read())
                {
                    bakiye = Convert.ToInt32(dr4[8].ToString());
                }
                dr4.Close();
                con.Close();

                con.Open();
                atmdekiPara.Connection = con;
                SqlDataReader dr5 = atmdekiPara.ExecuteReader();

                if (dr5.Read())
                {
                    MessageBox.Show(puancevirmebasarisiz);
                }

                else
                {
                    while (dr5.Read())
                    {
                        atmdekipara = Convert.ToInt32(dr5[1].ToString());
                    }

                    dr5.Close();
                    con.Close();

                    con.Open();
                    Puan.Connection = con;
                    SqlDataReader dr6 = Puan.ExecuteReader();
                    if (dr6.Read())
                    {
                        MessageBox.Show(puancevirmebasarisiz);
                    }

                    else
                    {
                        while (dr6.Read())
                        {
                            puan = Convert.ToInt32(dr6[9].ToString());
                        }
                        dr6.Close();
                    }

                    MessageBox.Show(puancevirmebasarili);

                    //islem tablosuna ekleme
                    DateTime tarih = new DateTime();
                    tarih = DateTime.Now;

                    SqlCommand islemekle = new SqlCommand("insert into islem(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                    islemekle.Parameters.AddWithValue("@miban", iban);
                    islemekle.Parameters.AddWithValue("@isim", isim);
                    islemekle.Parameters.AddWithValue("@soyisim", soyisim);
                    islemekle.Parameters.AddWithValue("@yapilanislem", "Puanları Paraya Çevirme");
                    islemekle.Parameters.AddWithValue("@miktar", miktar);
                    islemekle.Parameters.AddWithValue("@tarih", tarih);
                    islemekle.ExecuteNonQuery();

                    SqlCommand islemekleENG = new SqlCommand("insert into islemEng(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                    islemekleENG.Parameters.AddWithValue("@miban", iban);
                    islemekleENG.Parameters.AddWithValue("@isim", isim);
                    islemekleENG.Parameters.AddWithValue("@soyisim", soyisim);
                    islemekleENG.Parameters.AddWithValue("@yapilanislem", "Convert Points to Cash");
                    islemekleENG.Parameters.AddWithValue("@miktar", miktar);
                    islemekleENG.Parameters.AddWithValue("@tarih", tarih);
                    islemekleENG.ExecuteNonQuery();

                    con.Close();
                    this.Hide();
                    Form kullaniciekrani = new KullaniciEkran();
                    kullaniciekrani.Show();
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form odeme = new Odeme();
            odeme.FormClosed += Odeme_FormClosed;

            odeme.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form sansinidene = new SansiniDene();
            sansinidene.FormClosed += Sansinidene_FormClosed;

            sansinidene.Show();
            this.Hide();
        }

        private void Sansinidene_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form sansinidene = new SansiniDene();
            Form Kullaniciekrani = new KullaniciEkran();

            sansinidene.Hide();
            Kullaniciekrani.Show();
        }

        private void Odeme_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form odeme = new Odeme();
            Form kullaniciekrani = new KullaniciEkran();

            odeme.Hide();
            kullaniciekrani.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form askidapara = new AskidaPara();
            askidapara.FormClosed += Askidapara_FormClosed;

            askidapara.Show();
            this.Hide();
        }

        private void Askidapara_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form askidapara = new AskidaPara();
            Form kullaniciekrani = new KullaniciEkran();

            askidapara.Hide();
            kullaniciekrani.Show();
        }
    }
}
