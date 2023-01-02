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
    public partial class ParaTransferi : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public ParaTransferi()
        {
            InitializeComponent();
        }
        public int bakiye,iban;
        public string isim, soyisim,miktar;
        private void ParaTransferi_Load(object sender, EventArgs e)
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

            lblTransferYapilacakKisi.Text = Localization.lblTransferYapilacakKisi;
            lblTransferYapilacakMiktar.Text = Localization.lblTransferYapilacakMiktar;
            this.Text = Localization.ParaTransfer;

            this.musteriTableAdapter.Fill(this.bankaotomasyonDataSet1.musteri);
            gridmusteriler.Columns[0].HeaderText = "IBAN";
            gridmusteriler.Columns[1].HeaderText = Localization.gridAd;
            gridmusteriler.Columns[2].HeaderText = Localization.gridSoyad;
        }

        private void pb_resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
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

            int transferyapilan, transferyapan, transferyapilacaktutar = Convert.ToInt32(txtTransferYapilacakTutar.Text);

                transferyapilacaktutar = Convert.ToInt32(txtTransferYapilacakTutar.Text);


            //01110011 01101001 01101110 01100101 01101101 00100000 01100101 01101101 01101001 01110010 01101001 00100000 01100011 01101111 01101011 00100000 01110011 01100101 01110110 01101001 01101111 01101101 01110101 01110011

            con.Open();
                transferyapilan = bakiye + transferyapilacaktutar;
                string miban = gridmusteriler.CurrentRow.Cells[0].Value.ToString();
                SqlCommand transferYapilan = new SqlCommand("update musteri set m_bakiye = '" + transferyapilan + "' where musteri_iban = @iban");
                transferYapilan.Parameters.AddWithValue("@iban", miban);

            string transferyapilanisim = gridmusteriler.CurrentRow.Cells[1].Value.ToString();
            string transferyapilansoyisim = gridmusteriler.CurrentRow.Cells[2].Value.ToString();

                transferYapilan.Connection = con;
                SqlDataReader dr = transferYapilan.ExecuteReader();
            
                if (dr.Read())

                    MessageBox.Show(Localization.ParatransferBasarisiz);


                else
                {
                    while (dr.Read())
                    {
                        bakiye = Convert.ToInt32(dr[8].ToString());
                    }
                    
                    dr.Close();
                    

                }

                transferyapan = bakiye - transferyapilacaktutar;
                SqlCommand transferYapan = new SqlCommand("update musteri set m_bakiye = '" + transferyapan + "' where kullaniciAdi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
                transferYapan.Connection = con;
                SqlDataReader dr2 = transferYapan.ExecuteReader();
            
            if (dr2.Read())

                MessageBox.Show(Localization.ParatransferBasarisiz);


            else
            {
                while (dr2.Read())
                {
                    bakiye = Convert.ToInt32(dr[8].ToString());
                }

                dr2.Close();
                
                MessageBox.Show(Localization.ParatransferBasarili);

                //islem tablosuna ekleme
                miktar = txtTransferYapilacakTutar.Text.ToString();
                DateTime tarih = new DateTime();
                tarih = DateTime.Now;

                SqlCommand islemekle = new SqlCommand("insert into islem(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                islemekle.Parameters.AddWithValue("@miban", iban);
                islemekle.Parameters.AddWithValue("@isim", isim);
                islemekle.Parameters.AddWithValue("@soyisim", soyisim);
                islemekle.Parameters.AddWithValue("@yapilanislem", "Para Transferi: "+transferyapilanisim+" "+transferyapilansoyisim+"");
                islemekle.Parameters.AddWithValue("@miktar", miktar);
                islemekle.Parameters.AddWithValue("@tarih", tarih);
                islemekle.ExecuteNonQuery();

                SqlCommand islemekleENG = new SqlCommand("insert into islemEng(musteri_iban,islemyapanisim,islemyapansoyisim,yapilanislem,miktar,tarih) values (@miban,@isim,@soyisim,@yapilanislem,@miktar,@tarih)", con);
                islemekleENG.Parameters.AddWithValue("@miban", iban);
                islemekleENG.Parameters.AddWithValue("@isim", isim);
                islemekleENG.Parameters.AddWithValue("@soyisim", soyisim);
                islemekleENG.Parameters.AddWithValue("@yapilanislem", "Money Transfer: " + transferyapilanisim + " " + transferyapilansoyisim + "");
                islemekleENG.Parameters.AddWithValue("@miktar", miktar);
                islemekleENG.Parameters.AddWithValue("@tarih", tarih);
                islemekleENG.ExecuteNonQuery();

                con.Close();
                Form kullaniciekrani = new KullaniciEkran();
                this.Hide();
                kullaniciekrani.Show();
            }


        }

        private void gridmusteriler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
