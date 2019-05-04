using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingDream.Entity
{
    class EntVendor
    {
        private string nama_vendor;
        private string alamat_vendor;
        private string email;
        private string website;
        private int telp;

        public void setNamaVendor(string nama_vendor)
        {
            this.nama_vendor = nama_vendor;
        }
        public void setAlamatVendor(string alamat_vendor)
        {
            this.alamat_vendor = alamat_vendor;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setWebsite(string website)
        {
            this.website = website;
        }
        public void setTelp(int telp)
        {
            this.telp = telp;
        }

        public string getNamaVendor()
        {
            return nama_vendor;
        }
        public string getAlamatVendor()
        {
            return alamat_vendor;
        }
        public string getEmail()
        {
            return email;
        }
        public string getWebsite()
        {
            return website;
        }

        public int getTelp()
        {
            return telp;
        }
    }
}
