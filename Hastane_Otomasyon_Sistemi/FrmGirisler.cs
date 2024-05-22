using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon_Sistemi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHastaGirişi_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş form = new FrmHastaGiriş();
            form.Show();
            this.Hide();

        }

        private void btnDoktorGirişi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş form = new FrmDoktorGiriş();
            form.Show();
            this.Hide();
        }

        private void btnSekreterGirişi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş form = new FrmSekreterGiriş();
            form.Show();
            this.Hide();

        }
    }
}
