using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistem_Informasi_Akademis.View
{
    public partial class Admin : Form
    {
        private SqlConnection connection;
        private SqlCommand command;
        private string query;

        public Admin()
        {
            connection = Koneksi.KoneksiDB.Koneksi;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tb_admin";
            command = connection.CreateCommand();
            command.CommandText = query;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds, "data");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "data";
        }
    }
}
