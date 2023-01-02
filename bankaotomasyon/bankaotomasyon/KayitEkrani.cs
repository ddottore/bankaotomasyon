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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace bankaotomasyon
{
    public partial class KayitEkrani : Form
    {
        string kayitolusturmabasarili, kullaniciadikullanimda = "";
        SqlConnection con;
        SqlDataReader dr,drkontrol;
        SqlCommand com;

        public KayitEkrani()
        {
            InitializeComponent();
        }

        public static bool Email_Format_Kontrol(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            //database bağlama//
            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select*from musteri where kullaniciAdi = '" + txtKadi.Text + "' ";
            dr = com.ExecuteReader();

            string kullaniciadi = txtKadi.Text;
            string sifre = txtSifre.Text;
            string refkodu = txtRefKodu.Text;
            string isim = txtİsim.Text;
            string soyisim = txtSoyisim.Text;
            string yas = txtYas.Text;
            string tc = txtTC.Text;
            string email = txtemail.Text;

            if (dr.Read())
            {
                MessageBox.Show(kullaniciadikullanimda);
            }
            
            else
            {
                

                if (Email_Format_Kontrol(email)==true)
                {
                    int su, dogalgaz, elektrik;

                    dr.Close();
                    SqlCommand ekle = new SqlCommand("insert into musteri(m_ad,m_soyad,m_yas,m_tc,kullaniciAdi,kullaniciSifre,refKodu,email,su,dogalgaz,elektrik) values ('" + isim + "','" + soyisim + "','" + yas + "','" + tc + "','" + kullaniciadi + "','" + sifre + "','" + refkodu +"','" + email + "',@su,@dogalgaz,@elektrik)", con);

                    Random rnd = new Random();      //faturalar için rastgele sayı atama
                    su = rnd.Next(40, 245);
                    dogalgaz = rnd.Next(95, 1015);
                    elektrik = rnd.Next(100, 781);

                    ekle.Parameters.AddWithValue("@su", su);
                    ekle.Parameters.AddWithValue("@dogalgaz", dogalgaz);
                    ekle.Parameters.AddWithValue("@elektrik", elektrik);

                    ekle.ExecuteNonQuery();

                    MessageBox.Show(kayitolusturmabasarili);



                    //yönetici hesabının kontrolüne bağlı olarak kayıt ekranından sonra hangi formun açılacağını belirleme
                    string kullaniciAdi = Giris.kullaniciAdi;
                    string referanskodu = ReferansGiris.referanskodu;

                    SqlCommand comkontrol = new SqlCommand("select * from yonetici where yoneticikullaniciadi='" + kullaniciAdi + "' or refkodu = '" + referanskodu + "'");

                    con.Close();
                    con.Open();

                    comkontrol.Connection = con;
                    drkontrol = comkontrol.ExecuteReader();

                    if(drkontrol.Read())
                    {
                        this.Hide();
                        Form yoneticigirisi = new YoneticiGirisi();
                        yoneticigirisi.Show();
                        drkontrol.Close();
                    }

                    else
                    {
                        this.Hide();
                        Form giris = new Giris();
                        giris.Show();
                    }
                    con.Close();

                }
                else
                {
                    MessageBox.Show(Localization.yanlismail);
                }
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

            lblKullaniciAdi.Text = Localization.lblKullaniciAdi;
            lblPassword.Text = Localization.lblPassword;
            btnKayit.Text = Localization.btnKayit;
            lblİsim.Text = Localization.lblİsim;
            lblSoyisim.Text = Localization.lblSoyisim;
            lblYas.Text = Localization.lblYas;
            lblTC.Text = Localization.lblTC;
            lblReferansKodu.Text = Localization.lblReferansKodu;
            this.Text = Localization.KayitEkrani;
            kullaniciadikullanimda = Localization.KullaniciAdiKullanimda;
            kayitolusturmabasarili = Localization.KayıtOlusturmaBasarili;
            
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

        private void KayitEkrani_Load(object sender, EventArgs e)
        {
            metinYazdir();
        }
    }
}
