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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        SqlBaglantısı bgl = new SqlBaglantısı();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            //ad soyad çekme
            SqlCommand komut = new SqlCommand("select hastaAd, hastaSoyad from tbl_Hastalar where hastaTC=@p1",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",lblTC.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //randevu geçmişini listeleme
            //veri tablosu oluşturduk
            DataTable dt = new DataTable();
            //datagride verileri aktarmak için kullanılan command
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where hastaTc=" + tc,bgl.baglanti());
            //dataadapterın içini tablodan gelen değerlerle doldur.
            da.Fill(dt);
            //veri kaynağı =dtden gelen tablo.
            dataGridView1.DataSource = dt;

            //branşları çekme

            SqlCommand komut2 = new SqlCommand("select bransAd from Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBranş.Items.Add(dr2[0]);
            }

            //seçilen branşa göre doktor seçme 

            
        }

        private void cmbBranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorAd,doktorSoyad from Tbl_Doktorlar where doktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbBranş.Text);
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
               cmbDoktor.Items.Add(dr[0]+" "+dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Randevular where randevuBrans='" + cmbBranş.Text+"'", bgl.baglanti()) ;
            da.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void lnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle frm = new FrmBilgiDüzenle();
            frm.tcno = lblTC.Text;
            frm.Show();

        }
    }
}
