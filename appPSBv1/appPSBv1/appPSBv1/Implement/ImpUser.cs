using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace appPSBv1.Implement
{
    class ImpUser:Interface.IntfUser
    {
        private String querylogin;
        private Boolean statuslogin;
        private MySqlConnection koneksi;

        public ImpUser(){
            koneksi = KoneksiDB.Koneksi.GetKoneksi();
        }
        public Boolean LoginUser(String user, String pass){
            querylogin = "SELECT username, password FROM user WHERE username='"+user+"' AND password='"+pass+"'";

            koneksi.Open();
            MySqlCommand command = koneksi.CreateCommand();
            command.CommandText = querylogin;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()){
                if ((reader.GetString(0).ToString() == user) && (reader.GetString(1).ToString() == pass)){
                    statuslogin = true;
                }else{
                    statuslogin = false;
                }
            }
            koneksi.Close();
            return statuslogin;
        }
    }
}
