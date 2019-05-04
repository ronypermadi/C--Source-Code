using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;
using WeddingDream.Interface;

namespace WeddingDream.Implement
{
    class ImpPaket:IntfPaket
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private string query;

        public ImpPaket()
        {

            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public DataTable cmbPaket()
        {
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM paket";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return dt;
        }

        public DataSet viewPaket()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM paket";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "paket");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }

        public Boolean insertPaket(EntPaket ep)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "INSERT INTO paket (id_vendor,nama_paket,harga) VALUES ('" + ep.getIDVendor() + "' ,'" + ep.getNamaPaket() + "' , " + ep.getHarga() + ")";
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

        public Boolean updatePaket(EntPaket ep, int id_paket)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "UPDATE paket SET id_vendor ='" + ep.getIDVendor() + "', nama_paket ='" + ep.getNamaPaket() + "', harga =" + ep.getHarga() + " WHERE id_paket=" + id_paket + "";
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

        public Boolean deletePaket(int id_paket)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "DELETE FROM paket WHERE id_paket = " + id_paket + "";
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
