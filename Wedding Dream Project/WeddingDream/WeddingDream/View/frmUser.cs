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
    public partial class frmUser : Form
    {
        private MySqlConnection koneksi;
        private ImpUser impUser;
        private EntUser entUser;
        private Boolean status;
        private int id_user;

        public frmUser() {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impUser = new ImpUser();
            entUser = new EntUser();
            InitializeComponent();
            txtUsername.Focus();
        }

        void viewUser()
        {
            DataSet ds = impUser.viewUser();
            dgvUser.DataSource = ds;
            dgvUser.DataMember = "user";
        }


        private void frmUser_Load(object sender, EventArgs e)
        {
            txtID.Hide();
            viewUser();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi !");
                txtUsername.Focus();
            }
            else
            {
                entUser.setUsername(txtUsername.Text);
                entUser.setPassword(txtPassword.Text);
                
                status = impUser.insertUser(entUser);
                
                if (status == false)
                {
                    MessageBox.Show("Input Failed !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Input Success !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
                viewUser();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password harus diisi !");
                txtUsername.Focus();
            }
            else
            {
                id_user = Int16.Parse(txtID.Text);
                //entUser.setId_User(Int16.Parse(txtID.Text));
                entUser.setUsername(txtUsername.Text);
                entUser.setPassword(txtPassword.Text);

                status = impUser.updateUser(entUser,id_user);

                if (status == false)
                {
                    MessageBox.Show("Update Failed !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
                else
                {
                    MessageBox.Show("Update Success !!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtUsername.Focus();
                }
                viewUser();
            }

            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Hide();
            txtID.Show();
            txtID.Enabled = false;
            txtID.Text = dgvUser.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUser.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPassword.Text = dgvUser.Rows[e.RowIndex].Cells[2].Value.ToString();

            id_user = Int16.Parse(txtID.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            impUser.deleteUser(id_user);
            viewUser();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
            lblID.Show();
            txtID.Hide();
        }
    }
}
