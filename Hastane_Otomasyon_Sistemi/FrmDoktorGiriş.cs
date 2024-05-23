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
    public partial class FrmDoktorGiriş : Form
    {
        public FrmDoktorGiriş()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Tbl_Doktorlar where doktorTc=@p1 and doktorSifre=@p2 ",bgl.baglanti());

            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.Parameters.AddWithValue("@p2",txtsifre.Text);

            SqlDataReader fr = komut.ExecuteReader();

            if (fr.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.tcNumara = mskTC.Text;
               
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı şifre & TC", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
        }
    }
}
