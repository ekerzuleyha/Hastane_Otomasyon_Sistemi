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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Sekreter where sekreterTC=@p1 and sekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            //if olacak çünkü okumanın doğru olup olmadığını kontrol ediyor.
            if (dr.Read())
            {
                FrmSekreterDetay frm = new FrmSekreterDetay();
                frm.tcnumara = mskTC.Text;
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre" , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
