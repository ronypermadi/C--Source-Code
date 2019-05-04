using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDream.Entity
{
    class EntPaket
    {
        private string nama_paket;
        private int harga;
        private int id_vendor;

        public void setNamaPaket(string nama_paket)
        {
            this.nama_paket = nama_paket;
        }
        public void setHarga(int harga)
        {
            this.harga = harga;
        }
        public void setIDVendor(int id_vendor)
        {
            this.id_vendor = id_vendor;
        }


        public string getNamaPaket()
        {
            return nama_paket;
        }

        public int getHarga()
        {
            return harga;
        }
        public int getIDVendor()
        {
            return id_vendor;
        }
    }
}
