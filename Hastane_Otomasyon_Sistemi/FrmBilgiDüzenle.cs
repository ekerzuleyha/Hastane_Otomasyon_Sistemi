﻿using System;
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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string tcno;

        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = tcno;
        }
    }
}
