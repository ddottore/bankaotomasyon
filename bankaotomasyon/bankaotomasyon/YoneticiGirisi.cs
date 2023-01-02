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
    public partial class YoneticiGirisi : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com,comsil,yenile;


        public string yoneticiad, yoneticisoyad;

        public YoneticiGirisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kayitekrani = new KayitEkrani();
            kayitekrani.Show();
            kayitekrani.FormClosed += Kayitekrani_FormClosed;
        }

        private void Kayitekrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form kayitekrani = new KayitEkrani();
            Form yoneticigirisi = new YoneticiGirisi();

            kayitekrani.Hide();
            yoneticigirisi.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form yapilanislemler = new YapilanIslemler();
            yapilanislemler.Show();
            this.Hide();
            yapilanislemler.FormClosed += Yapilanislemler_FormClosed;
        }

        private void Yapilanislemler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form yapilanislemler = new YapilanIslemler();
            Form yoneticigirisi = new YoneticiGirisi();
            yoneticigirisi.Show();
            this.Hide();
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

            this.Text = Localization.YoneticiGirisi;

            this.musteriTableAdapter1.Fill(this.bankaotomasyonDataSet11.musteri);
            gridmusteriler.Columns[0].HeaderText = "IBAN";
            gridmusteriler.Columns[1].HeaderText = Localization.lblKullaniciAdi;
            gridmusteriler.Columns[2].HeaderText = Localization.lblPassword;
            gridmusteriler.Columns[3].HeaderText = Localization.lblReferansKodu;
            gridmusteriler.Columns[4].HeaderText = Localization.gridAd;
            gridmusteriler.Columns[5].HeaderText = Localization.gridSoyad;
            gridmusteriler.Columns[6].HeaderText = Localization.lblYas;
            gridmusteriler.Columns[7].HeaderText = "TC";
            gridmusteriler.Columns[8].HeaderText = Localization.label2;
            gridmusteriler.Columns[9].HeaderText = Localization.label3;
            btnIslemGecmisi.Text = Localization.btnIslemGecmisi;
            btnMusteriKaydiOlustur.Text = Localization.btnMusteriKaydiOlustur;
            btnMusteriSil.Text = Localization.btnMusteriSil;
            lblHosgeldinYonetici.Text = Localization.lblHosgeldinYonetici;
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
            Yenile();
            metinYazdir();
        }

        private void pb_resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
        }

        private void YoneticiGirisi_FormClosing(object sender, FormClosingEventArgs e)
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

        public void Yenile()
        {
            //Datagridview verileri yenileme (refresh)
            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            con.Open();
            yenile = new SqlCommand();
            yenile.Connection = con;
            yenile = new SqlCommand("select*from musteri", con);
            SqlDataAdapter da = new SqlDataAdapter(yenile);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gridmusteriler.DataSource = null;
            gridmusteriler.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            comsil = new SqlCommand("delete from musteri where musteri_iban = @iban");
            con.Open();
            comsil.Connection = con;
            string miban = gridmusteriler.CurrentRow.Cells[0].Value.ToString();
            comsil.Parameters.AddWithValue("@iban", miban);
            SqlDataReader drsil = comsil.ExecuteReader();
            
            drsil.Close();

            Yenile();

            con.Close();
        }

        private void YoneticiGirisi_Load(object sender, EventArgs e)
        {
            Yenile();
            metinYazdir();

            this.musteriTableAdapter1.Fill(this.bankaotomasyonDataSet11.musteri);

            string kullaniciAdi = Giris.kullaniciAdi;
            string referanskodu = ReferansGiris.referanskodu;

            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com = new SqlCommand("select * from yonetici where yoneticikullaniciadi='" + kullaniciAdi + "' or refKodu = '" + referanskodu + "'");
            com.Connection = con;
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                yoneticiad = dr[3].ToString();
                yoneticisoyad = dr[4].ToString();

            }

            dr.Close();
            con.Close();

            lbl_yoneticiadsoyad.Text = "" + yoneticiad + " " + yoneticisoyad + "";

        }
    }
}
