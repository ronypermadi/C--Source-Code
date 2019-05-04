using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDream.KoneksiDB
{
    class Koneksi
    {
        public static MySqlConnection getKoneksi()
        {
            string strCon = "SERVER = localhost; PORT = 3306;" +
                            "UID =  root; PWD = ;" +
                            "DATABASE = weddingdream_db;";
            return new MySqlConnection(strCon);
        }
    }
}
