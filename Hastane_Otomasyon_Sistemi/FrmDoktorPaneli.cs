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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();


        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            //doktorları aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select* from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //bransları aktarma
            SqlCommand bransEkle = new SqlCommand("select bransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = bransEkle.ExecuteReader();
            while (dr1.Read())
            {
                cmbbranş.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("Insert into Tbl_Doktorlar (doktorAd,doktorSoyad,doktorBrans,doktorTC,doktorSifre) values (@d1,@d2,@d3,@d4,@d5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",txtad.Text);
            komut.Parameters.AddWithValue("@d2",txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3",cmbbranş.Text);
            komut.Parameters.AddWithValue("@d4",msktc.Text);
            komut.Parameters.AddWithValue("@d5",txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

      
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbbranş.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();


        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Doktorlar where doktorTC=@p1", bgl.baglanti()) ;
            komut.Parameters.AddWithValue("@p1",msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Doktorlar set doktorAd=@d1, doktorSoyad=@d2, doktorBrans=@d3, doktorSifre=@d5 where doktorTC=@d4",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtsifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
