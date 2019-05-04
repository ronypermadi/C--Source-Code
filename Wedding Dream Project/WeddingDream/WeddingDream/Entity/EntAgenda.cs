using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDream.Entity
{
    class EntAgenda
    {
        private string judul;
        private string tempat;
        private string tgl;
        private int id_customer;

        public void setJudul(string judul)
        {
            this.judul = judul;
        }

        public string getJudul()
        {
            return judul;
        }

        public void setTempat(string tempat)
        {
            this.tempat = tempat;
        }

        public string getTempat()
        {
            return tempat;
        }

        public void setTgl(string tgl)
        {
            this.tgl = tgl;
        }

        public string getTgl()
        {
            return tgl;
        }

        public void setIDCustomer(int id_customer)
        {
            this.id_customer = id_customer;
        }

        public int getIDCustomer()
        {
            return id_customer;
        }

    }
}
