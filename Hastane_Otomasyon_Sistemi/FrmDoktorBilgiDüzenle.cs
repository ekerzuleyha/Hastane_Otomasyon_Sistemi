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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();
        public string tcnumara;

        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcnumara;

            //tcsi gelen doktorun diğer bilgilerinide getirme 

            SqlCommand komut = new SqlCommand("select * from tbl_Doktorlar where doktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                cmbBrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();


        }

        private void btnBilgiGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand a = new SqlCommand("Update tbl_Doktorlar set doktorAd=@p1, doktorSoyad=@p2, doktorBrans=@p3, doktorSifre=@p4 where doktorTC=@p5", bgl.baglanti());
            a.Parameters.AddWithValue("@p1",txtAd.Text);
            a.Parameters.AddWithValue("@p2",txtSoyad.Text);
            a.Parameters.AddWithValue("@p3",cmbBrans.Text);
            a.Parameters.AddWithValue("@p4",txtsifre.Text);
            a.Parameters.AddWithValue("@p5",mskTC.Text);
            a.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        
    }
}
