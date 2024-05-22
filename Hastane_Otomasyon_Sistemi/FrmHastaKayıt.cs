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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();

        private void btnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(hastaAd,hastaSoyad,hastaTC,hastaTelefon,hastaSifre,hastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text);
            komut.Parameters.AddWithValue("@p4",mskTelefon.Text);
            komut.Parameters.AddWithValue("@p5",txtsifre.Text);
            komut.Parameters.AddWithValue("@p6",cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleştirilmiştir. Şifreniz: "+txtsifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
