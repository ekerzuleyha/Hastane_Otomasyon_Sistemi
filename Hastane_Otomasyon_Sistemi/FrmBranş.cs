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
    public partial class FrmBranş : Form
    {
        public FrmBranş()
        {
            InitializeComponent();
        }


        SqlBaglantısı bgl = new SqlBaglantısı();

        private void FrmBranş_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (bransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtbranş.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

         
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Tbl_Branslar where bransId=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[seçilen].Cells[0].Value.ToString();
            txtbranş.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Branslar set bransAd=@p1 where bransId=@p2", bgl.baglanti()) ;
            komut.Parameters.AddWithValue("@p1",txtbranş.Text);
            komut.Parameters.AddWithValue("@p2",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
           
        }
    }
}
