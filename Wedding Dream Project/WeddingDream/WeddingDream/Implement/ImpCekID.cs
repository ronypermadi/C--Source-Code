using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Interface;

namespace WeddingDream.Implement
{
    class ImpCekID:IntfCekID
    {
        private MySqlConnection koneksi;
        private string query;

        public ImpCekID()
        {

            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public DataSet viewCekID(String key)
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM " + key;
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds,key);
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }

            
            return ds;
        }
    }
}
