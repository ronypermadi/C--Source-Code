using System;
using System.Data.SqlClient;

namespace Sistem_Informasi_Akademis.Implement
{
    class ImpLogin : Interface.IntLogin
    {
        private string query;
        private Boolean status;
        private SqlConnection connection;
        
        public ImpLogin()
        {
            connection = Koneksi.KoneksiDB.Koneksi;
        }

        public Boolean login(Entity.EntLogin e)
        {
            query = "Select id_user, password From tb_admin " +
                    "Where id_user = '" + e.User +
                    "' AND password = '" + e.Password + "'";
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if ((reader.GetString(0).ToString() == e.User)
                    && (reader.GetString(1).ToString() == e.Password))
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            connection.Close();
            return status;
        }
    }
}
