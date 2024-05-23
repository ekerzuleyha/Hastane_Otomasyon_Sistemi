using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Sistemi
{
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        SqlBaglantısı bgl = new SqlBaglantısı();
        public string tcNumara;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcNumara;

            //adsoyad yazdırma

            SqlCommand komut = new SqlCommand("select doktorAd,doktorSoyad from Tbl_Doktorlar where doktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read()) 
            {
                lblAdsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


            //doktora ait randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where randevuDoktor='" + lblAdsoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frm = new FrmDoktorBilgiDüzenle();
            frm.tcnumara = lblTC.Text;
            frm.Show();

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void btnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}
