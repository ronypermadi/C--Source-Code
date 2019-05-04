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
    class ImpDetail:IntfDetail
    {
        private MySqlConnection koneksi;
        private string query;

        public ImpDetail()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        /*public DataSet viewDetail()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT customer.id_customer,customer.nama_customer,pesanan.id_pesanan,agenda.id_agenda,agenda.judul_acara,vendor.id_vendor,vendor.nama_vendor,paket.id_paket FROM customer JOIN pesanan JOIN paket JOIN vendor JOIN agenda ON customer.id_customer=pesanan.id_customer AND customer.id_customer=agenda.id_customer AND vendor.id_vendor=paket.id_vendor AND pesanan.id_paket=paket.id_paket";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "detail");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }
        */
        public DataTable viewDetailID(String id)
        {
            DataTable dt = new DataTable();
            try
            {
                koneksi.Open();
                query = "SELECT customer.id_customer,customer.nama_customer,pesanan.id_pesanan,agenda.id_agenda,agenda.judul_acara,vendor.id_vendor,vendor.nama_vendor,paket.id_paket FROM customer JOIN pesanan JOIN paket JOIN vendor JOIN agenda ON customer.id_customer=pesanan.id_customer AND customer.id_customer=agenda.id_customer AND vendor.id_vendor=paket.id_vendor AND pesanan.id_paket=paket.id_paket WHERE customer.nama_customer LIKE '%" + id +"%'";
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
    }
}
