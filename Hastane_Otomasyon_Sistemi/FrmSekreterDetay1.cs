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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        SqlBaglantısı bgl = new SqlBaglantısı();
        public string tcnumara;
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tcnumara;

            //ad soyad getirme

            SqlCommand komut = new SqlCommand("select sekreterAdSoyad from Tbl_Sekreter where sekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();


            //branşları datagride aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktorları aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorAd+' '+doktorSoyad) as 'Doktorlar',doktorBrans from Tbl_Doktorlar",bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //combobaxa brans ekleme

            SqlCommand bransEkle = new SqlCommand("select bransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = bransEkle.ExecuteReader();
            while (dr1.Read())
            {
                cmbbranş.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //burada sekreter hastanın alabileceği randevuyu oluşturuyor.
            SqlCommand komutkaydet = new SqlCommand("insert into Tbl_Randevular (randevuTarih,randevuSaat,randevuBrans,randevuDoktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti()); ;

            komutkaydet.Parameters.AddWithValue("@r1",msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbbranş.Text);
            komutkaydet.Parameters.AddWithValue("@r4",cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu oluşturuldu.");
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            //combobaxa bransa göre doktor ekleme
            cmbdoktor.Items.Clear();
            SqlCommand doktor = new SqlCommand("select (doktorAd+' ' + doktorSoyad) from Tbl_Doktorlar where doktorBrans=@p1", bgl.baglanti());
            doktor.Parameters.AddWithValue("@p1",cmbbranş.Text);
            SqlDataReader dr2 = doktor.ExecuteReader();
            while (dr2.Read())
            {
                cmbdoktor.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnduyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void btnbranşpanel_Click(object sender, EventArgs e)
        {
            FrmBranş frm = new FrmBranş();
            frm.Show();
        }

        private void btnliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();

        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}
