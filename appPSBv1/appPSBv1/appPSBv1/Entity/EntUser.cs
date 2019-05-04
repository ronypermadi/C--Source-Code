using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appPSBv1.Entity
{
    class EntUser
    {
        private String username;
        private String password;
        public void SetUsername(String user) {
            username = user;
        }
        public String GetUsername(){
            return username;
        }
        public void SetPassword(String pass){
            password = pass;
        }
        public String GetPassword(){
            return password;
        }
    }
}
