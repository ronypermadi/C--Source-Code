using System.Data.SqlClient;

namespace Sistem_Informasi_Akademis.Koneksi
{
    class KoneksiDB
    {
        private static SqlConnection connection;

        public static SqlConnection Koneksi
        {
            get
            {
                connection = new SqlConnection
                {
                    ConnectionString = "Data Source = E5-475G;" +
                                       "Initial Catalog = db_psb;" +
                                       "Integrated Security = True"
                };

                return connection;
            }
        }
    }
}
