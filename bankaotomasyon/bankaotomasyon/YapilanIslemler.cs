using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace bankaotomasyon
{
    public partial class YapilanIslemler : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand yenile;

        public YapilanIslemler()
        {
            InitializeComponent();
        }

        public void Yenile()
        {
            //Datagridview verileri yenileme (refresh)
            con = new SqlConnection("Data Source=EMIR-PC\\SQLEXPRESS;Initial Catalog=bankaotomasyon;Integrated Security=True");
            con.Open();
            yenile = new SqlCommand();
            yenile.Connection = con;

            if (Settings.Default.lang == "English")
            {
                yenile.CommandText = "select* from islemEng";
            }

            else if (Settings.Default.lang == "Turkish")
            {
                yenile.CommandText = "select* from islem";
            }
            
            SqlDataAdapter da = new SqlDataAdapter(yenile);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            con.Close();
        }

            

        private void YapilanIslemler_Load(object sender, EventArgs e)
        {
            Yenile();
            metinYazdir();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void metinYazdir()
        {
            if (Settings.Default.lang == "English")
            {
                pb_resim.Image = Properties.Resources.turkey;
                Localization.Culture = new CultureInfo("en");
                this.islemTableAdapter1.Fill(this.bankaotomasyonDataSet11.islem);

            }
            else if (Settings.Default.lang == "Turkish")
            {
                pb_resim.Image = Properties.Resources.icons8_great_britain_96;
                Localization.Culture = new CultureInfo("");
                
                this.islemEngTableAdapter.Fill(this.bankaotomasyonDataSet11.islemEng);
            }

            this.Text = Localization.Yapilanislemler;

            this.islemEngTableAdapter.Fill(this.bankaotomasyonDataSet11.islemEng);
            dataGridView1.Columns[0].HeaderText = Localization.gridislemno;
            dataGridView1.Columns[1].HeaderText = "IBAN";
            dataGridView1.Columns[2].HeaderText = Localization.gridAd;
            dataGridView1.Columns[3].HeaderText = Localization.gridSoyad;
            dataGridView1.Columns[4].HeaderText = Localization.gridyapilanislem;
            dataGridView1.Columns[5].HeaderText = Localization.gridmiktar;
            dataGridView1.Columns[6].HeaderText = Localization.gridtarih;
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
    }
}
