using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDream.Entity
{
    class EntPesanan
    {
        private int id_customer;
        private int id_paket;
        private String tgl;

        public void setIDCustomer(int id_customer)
        {
            this.id_customer = id_customer;
        }
       
        public int getIDCustomer()
        {
            return id_customer;
        }

        public void setIDPaket(int id_paket)
        {
            this.id_paket = id_paket;
        }

        public int getIDPaket()
        {
            return id_paket;
        }

        public void setTgl(String tgl)
        {
            this.tgl = tgl;
        }

        public String getTgl()
        {
            return tgl;
        }

    }
}
