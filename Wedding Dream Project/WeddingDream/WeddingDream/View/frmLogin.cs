using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeddingDream.View;

namespace WeddingDream
{
    public partial class frmLogin : Form
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private Entity.EntUser login;
        private Implement.ImpUser impUser;

        public frmLogin()
        {
            impUser = new Implement.ImpUser();
            login = new Entity.EntUser();
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            try
            {
                koneksi.Open();
                Console.WriteLine("Koneksi Sukses");
            }
            catch
            {
                Console.WriteLine("Koneksi Gagal");

            }
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi !");
                txtUsername.Focus();
            }
            else
            {
                login.setUsername(txtUsername.Text);
                login.setPassword(txtPassword.Text);

                status = impUser.Login(login);

                if (status == false)
                {
                    MessageBox.Show("Login Failed !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                }
                else
                {
                    MessageBox.Show("Login Success");
                    frmAdmin f = new frmAdmin();              
                    f.Show();                                       
                    this.Hide();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
         
            frmRegister r = new frmRegister();
            r.Show();
            this.Hide();
            
        }
    }
}
