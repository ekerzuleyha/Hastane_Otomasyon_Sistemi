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
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        SqlBaglantısı bgl = new SqlBaglantısı();

        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable db = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Duyurular",bgl.baglanti());
            da.Fill(db);
            dataGridView1.DataSource = db;
        }
    }
}
