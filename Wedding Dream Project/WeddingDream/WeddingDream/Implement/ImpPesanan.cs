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
    class ImpPesanan:IntfPesanan
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private string query;

        public ImpPesanan()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public int ViewID()
        {
            int kode = 0;
            try
            {
                query = "SELECT * FROM pesanan";
                koneksi.Open();
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    kode = reader.GetInt32(0) + 1;
                }
                
                koneksi.Close();
            }
            catch (MySqlException)
            {
                Console.WriteLine("ERROR ");
            }
            return kode;
        }

        public DataSet viewPesanan()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM pesanan";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "pesanan");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }

        public Boolean insertPesanan(EntPesanan ep)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "INSERT INTO pesanan (id_customer,id_paket,tgl_pesan) VALUES ('" + ep.getIDCustomer() + "' ,'" + ep.getIDPaket() + "' , '" + ep.getTgl() + "')";
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

        public Boolean updatePesanan(EntPesanan ep, int id_pesanan)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "UPDATE pesanan SET id_customer ='" + ep.getIDCustomer() + "', id_paket ='" + ep.getIDPaket() + "', tgl_pesan ='" + ep.getTgl() + "' WHERE id_pesanan=" + id_pesanan + "";
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

        public Boolean deletePesanan(int id_pesanan)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "DELETE FROM pesanan WHERE id_pesanan = " + id_pesanan + "";
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
