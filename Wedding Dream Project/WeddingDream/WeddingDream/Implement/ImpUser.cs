using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;
using WeddingDream.Interface;
using WeddingDream.View;

namespace WeddingDream.Implement
{
    class ImpUser: IntfUser
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private string query;

        public ImpUser()
        {
            
            koneksi = KoneksiDB.Koneksi.getKoneksi();
        }

        public Boolean Login(EntUser eu)
        {
            
            koneksi.Open();
            query = "SELECT username,password FROM user WHERE username = '" + eu.getUsername() + "' AND password = '" + eu.getPassword() + "'";
            MySqlCommand command = koneksi.CreateCommand();
            command.CommandText = query;
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == eu.getUsername())
                    && (reader.GetString(1).ToString() == eu.getPassword()))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            koneksi.Close();

            return status;
        }

        public DataSet viewUser()
        {
            DataSet ds = new DataSet();
            try
            {
                koneksi.Open();
                query = "SELECT * FROM user";
                MySqlCommand command = koneksi.CreateCommand();
                command.CommandText = query;
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(ds, "user");
                koneksi.Close();
            }
            catch (MySqlException me)
            {
                Console.WriteLine(me);
            }
            return ds;
        }

        public Boolean insertUser(EntUser eu)
        {
            status=false;
            try
            {
                koneksi.Open();
                query = "INSERT INTO user (username,password) VALUES ('" + eu.getUsername() + "' , '" + eu.getPassword() + "')";
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

        public Boolean updateUser(EntUser eu, int id_user)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "UPDATE user SET username ='"+ eu.getUsername() +"', password ='"+ eu.getPassword() +"' WHERE id_users="+ id_user +"";
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

        public Boolean deleteUser(int id_user)
        {
            status = false;
            try
            {
                koneksi.Open();
                query = "DELETE FROM user WHERE id_users = " + id_user+ "";
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
