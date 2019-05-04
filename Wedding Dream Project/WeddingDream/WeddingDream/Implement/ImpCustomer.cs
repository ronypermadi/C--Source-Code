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
    class ImpCustomer:IntfCustomer
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private string query;

        public ImpCustomer()
        {

            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public DataTable cmbCustomer()
        {
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM customer";
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

        public DataSet viewCustomer()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM customer";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "customer");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }

        public Boolean insertCustomer(EntCustomer ec)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "INSERT INTO customer (nama_customer,alamat,email,no_hp) VALUES ('" + ec.getNamaCustomer() + "' , '" + ec.getAlamat() + "', '" + ec.getEmail() + "', '" + ec.getHP() + "')";
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

        public Boolean updateCustomer(EntCustomer ec, int id_customer)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "UPDATE customer SET nama_customer ='" + ec.getNamaCustomer() + "', alamat ='" + ec.getAlamat() + "', email ='" + ec.getEmail() + "', no_hp ='" + ec.getHP() + "' WHERE id_customer=" + id_customer + "";
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

        public Boolean deleteCustomer(int id_customer)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "DELETE FROM customer WHERE id_customer = " + id_customer + "";
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
