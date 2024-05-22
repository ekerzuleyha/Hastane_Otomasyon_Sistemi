using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Otomasyon_Sistemi
{
    class SqlBaglantısı
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-58O17EO;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}

