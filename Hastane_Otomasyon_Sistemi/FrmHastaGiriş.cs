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
    public partial class FrmHastaGiriş : Form
    {
        public FrmHastaGiriş()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();

        private void lnküyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt form = new FrmHastaKayıt();
            form.Show();


        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select* from tbl_hastalar where hastaSifre=@p2 and hastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();
            //eğer dr doğru bir şekilde okuma işlemini gerçekleştiriyorsa yapsın
            if (dr.Read())
            {
                FrmHastaDetay form = new FrmHastaDetay();
                form.tc = mskTC.Text;
                
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            bgl.baglanti().Close();
        }
    }
}
