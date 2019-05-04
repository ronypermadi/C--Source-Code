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
using WeddingDream.Entity;
using WeddingDream.Implement;

namespace WeddingDream.View
{
    public partial class frmRegister : Form
    {
        private MySqlConnection koneksi;
        private Boolean status;
        private EntUser login;
        private ImpUser impUser;

        public frmRegister()
        {

            impUser = new ImpUser();
            login = new EntUser();
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
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

                status = impUser.insertUser(login);

                if (status == false)
                {
                    MessageBox.Show("Register Failed !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                }
                else
                {
                    MessageBox.Show("Register Success !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();

                    frmLogin l = new frmLogin();
                    l.Show();
                    this.Hide();
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();
            this.Hide();
        }
    }    
    }
