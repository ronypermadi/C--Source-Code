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
    class ImpVendor:IntfVendor
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private string query;

        public ImpVendor()
        {

            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public DataTable cmbVendor()
        {
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM vendor";
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

        public DataSet viewVendor()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM vendor";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "vendor");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }

        public Boolean insertVendor(EntVendor ev)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "INSERT INTO vendor (nama_vendor,alamat_vendor,telp,email,website) VALUES ('" 
                    + ev.getNamaVendor() + "' , '" + ev.getAlamatVendor() + "' , '"
                    + ev.getTelp() + "' , '" + ev.getEmail() + "' , '"
                    + ev.getWebsite() + "')";
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

        public Boolean updateVendor(EntVendor ev, int id_vendor)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "UPDATE vendor SET nama_vendor ='" + ev.getNamaVendor() + 
                    "', alamat_vendor ='" + ev.getAlamatVendor() +
                    "', telp ='" + ev.getTelp() +
                    "', email ='" + ev.getEmail() +
                    "', website ='" + ev.getWebsite() +
                    "' WHERE id_vendor =" + id_vendor + "";
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

        public Boolean deleteVendor(int id_vendor)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "DELETE FROM vendor WHERE id_vendor = " + id_vendor + "";
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
