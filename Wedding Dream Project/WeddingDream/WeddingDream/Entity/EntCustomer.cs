using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDream.Entity
{
    class EntCustomer
    {
        private string nama_customer;
        private string alamat;
        private string email;
        private int hp;

        public void setNamaCustomer(string nama_customer)
        {
            this.nama_customer = nama_customer;
        }
        public string getNamaCustomer()
        {
            return nama_customer;
        }
        public void setAlamat(string alamat)
        {
            this.alamat = alamat;
        }
        public string getAlamat()
        {
            return alamat;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return email;
        }
        public void setHP(int hp)
        {
            this.hp = hp;
        }
        public int getHP()
        {
            return hp;
        }
    }
}
