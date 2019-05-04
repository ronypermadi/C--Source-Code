using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace appPSBv1.KoneksiDB
{
    class Koneksi
    {
        private static MySqlConnection koneksi;

        public static MySqlConnection GetKoneksi()
        {
            koneksi = new MySqlConnection();
            //koneksi.ConnectionString = "Data Source=DESKTOP-00TM3B1\\SQLEXPRESS;Initial Catalog=db_psb;Integrated Security=True";
            koneksi.ConnectionString = "SERVER=localhost;PORT=3306;UID=root;PWD= ;DATABASE=apppsb_db";
                return koneksi;
        }
    }
}
