using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sistem_Informasi_Akademis
{
    public partial class Login : Form
    {
        private Boolean status;
        private SqlConnection connection;
        private Entity.EntLogin login;
        private Implement.ImpLogin implogin;

        public Login()
        {
            connection = Koneksi.KoneksiDB.Koneksi;

            try
            {
                connection.Open();
                Console.WriteLine("Koneksi Sukses !");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Koneksi Gagal, " + e);
            }

            InitializeComponent();

            implogin = new Implement.ImpLogin();
            login = new Entity.EntLogin();


        }

        private void btnSignIn_Click(object sender, System.EventArgs e)
        {
            login.User = txtUser.Text;
            login.Password = txtPassword.Text;

            status = implogin.login(login);


            if (status == false)
            {
                MessageBox.Show("Maaf login gagal");
                txtUser.Clear();
                txtUser.Focus();
                txtPassword.Clear();
            }
            else
            {
                View.Admin admin = new View.Admin();
                admin.Show();
                Hide();
            }
            /*
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Kode dan Password harus diisi !");
            }
            else
            {
                
            }
            */
        }
    }
}
