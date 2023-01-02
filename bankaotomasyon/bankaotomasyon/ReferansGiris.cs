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
    public partial class ReferansGiris : Form
    {
        SqlConnection con;
        SqlDataReader dr,dr2;
        SqlCommand com,com2;
        public ReferansGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string referanskodu, hataliref;

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

            btnGiris.Text = Localization.btnGiris;
            lblReferanskodu.Text = Localization.lblReferansKodu;
            this.Text = Localization.ReferansGiris;
            hataliref = Localization.hataliref;
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

        private void btnReferansGiris_Click(object sender, EventArgs e)
        {
            referanskodu = txtReferansKodu.Text;

            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            com = new SqlCommand();
            com2 = new SqlCommand();

            con.Open();
            
            com2.Connection = con;

            com.CommandText = "select * from musteri where refKodu = '" + txtReferansKodu.Text +  "' ";
            com2.CommandText = "select * from yonetici where refkodu = '" + txtReferansKodu.Text + "'";
            
            dr2 = com2.ExecuteReader();

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
                    MessageBox.Show(hataliref);
                }
                con.Close();
            }
        }

        private void ReferansGiris_Load(object sender, EventArgs e)
        {
            metinYazdir();
        }
    }
}
