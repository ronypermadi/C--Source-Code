using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;

namespace WeddingDream.Implement
{
    class ImpAgenda
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private string query;

        public ImpAgenda()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public DataSet viewAgenda()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM agenda";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "agenda");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }

        public Boolean insertAgenda(EntAgenda ea)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "INSERT INTO agenda (id_customer,judul_acara,tgl_acara,tempat) VALUES (" + ea.getIDCustomer() + " ,'" + ea.getJudul() + "' , '" + ea.getTgl() + "','" + ea.getTempat() + "')";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return status;
        }

        public Boolean updateAgenda(EntAgenda ea, int id_agenda)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "UPDATE agenda SET id_customer ='" + ea.getIDCustomer() + "', judul_acara ='" + ea.getJudul() + "', tgl_acara ='" + ea.getTgl() + "', tempat ='" + ea.getTempat() + "' WHERE id_agenda=" + id_agenda + "";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return status;
        }

        public Boolean deleteAgenda(int id_agenda)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "DELETE FROM agenda WHERE id_agenda = " + id_agenda + "";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return status;
        }
    }
}
