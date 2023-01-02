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
    public partial class Odeme : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public Odeme()
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

            btnElektrik.Text = Localization.Elektrik;
            btnDogalgaz.Text = Localization.Dogalgaz;
            btnSu.Text = Localization.Su;
            lblOdenecekFatura.Text = Localization.lblOdenecekFaturaText;
            this.Text = Localization.btn_odeme;
            
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

        private void Odeme_Load(object sender, EventArgs e)
        {
            metinYazdir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form elektrik = new Elektrik();
            elektrik.FormClosed += Elektrik_FormClosed;
            this.Hide();
            elektrik.Show();
        }

        private void Elektrik_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form kullaniciekrani = new KullaniciEkran();
            this.Hide();
            kullaniciekrani.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form su = new Su();
            su.FormClosed += Su_FormClosed;
            this.Hide();
            su.Show();
        }

        private void Su_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form kullaniciekrani = new KullaniciEkran();
            this.Hide();
            kullaniciekrani.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form dogalgaz = new Dogalgaz();
            dogalgaz.FormClosed += Dogalgaz_FormClosed;
            this.Hide();
            dogalgaz.Show();
        }

        private void Dogalgaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form kullaniciekrani = new KullaniciEkran();
            this.Hide();
            kullaniciekrani.Show();
        }

        private void pb_resim_Click(object sender, EventArgs e)
        {
            resimGuncelle(pb_resim);
        }
    }
}
