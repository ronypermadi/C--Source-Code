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
    public partial class frmCustomer : Form
    {
        private MySqlConnection koneksi;
        private ImpCustomer impCustomer;
        private EntCustomer entCustomer;
        private Boolean status;
        private int id_customer;
        private int hp;

        
        void viewCustomer()
        {
            DataSet ds = impCustomer.viewCustomer();
            dgvCustomer.DataSource = ds;
            dgvCustomer.DataMember = "customer";
        }

        public frmCustomer()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impCustomer = new ImpCustomer();
            entCustomer = new EntCustomer();
            InitializeComponent();
            txtNama.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" || txtAlamat.Text == "" || txtEmail.Text == "" || txtHp.Text == "")
            {
                MessageBox.Show("Form harus diisi !");
                txtNama.Focus();
            }
            else
            {
                hp = Int32.Parse(txtHp.Text);
                entCustomer.setNamaCustomer(txtNama.Text);
                entCustomer.setAlamat(txtAlamat.Text);
                entCustomer.setEmail(txtEmail.Text);
                entCustomer.setHP(hp);

                status = impCustomer.insertCustomer(entCustomer);

                if (status == false)
                {
                    MessageBox.Show("Input Failed !!");
                    txtNama.Text = "";
                    txtAlamat.Text = "";
                    txtEmail.Text = "";
                    txtHp.Text = "";
                    txtNama.Focus();
                }
                else
                {
                    MessageBox.Show("Input Success !!");
                    txtNama.Text = "";
                    txtAlamat.Text = "";
                    txtEmail.Text = "";
                    txtHp.Text = "";
                    txtNama.Focus();
                }
                viewCustomer();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            impCustomer.deleteCustomer(id_customer);
            viewCustomer();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (txtNama.Text == "" || txtAlamat.Text == "" || txtEmail.Text == "" || txtHp.Text == "")
            {
                MessageBox.Show("Form harus diisi !");
                txtNama.Focus();
            }
            else
            {
                id_customer = Int16.Parse(txtID.Text);
                hp = Int32.Parse(txtHp.Text);
                entCustomer.setNamaCustomer(txtNama.Text);
                entCustomer.setAlamat(txtAlamat.Text);
                entCustomer.setEmail(txtEmail.Text);
                entCustomer.setHP(hp);

                status = impCustomer.updateCustomer(entCustomer,id_customer);

                if (status == false)
                {
                    MessageBox.Show("Update Failed !!");
                    txtNama.Text = "";
                    txtAlamat.Text = "";
                    txtEmail.Text = "";
                    txtHp.Text = "";
                    txtNama.Focus();
                }
                else
                {
                    MessageBox.Show("Update Success !!");
                    txtNama.Text = "";
                    txtAlamat.Text = "";
                    txtEmail.Text = "";
                    txtHp.Text = "";
                    txtNama.Focus();
                }
                viewCustomer();
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            viewCustomer();
            txtID.Hide();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Hide();
            txtID.Show();
            txtID.Enabled = false;
            txtID.Text = dgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNama.Text = dgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAlamat.Text = dgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHp.Text = dgvCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();

            id_customer = Int16.Parse(txtID.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtHp.Text = "";
            txtNama.Focus();
            lblID.Show();
            txtID.Hide();
        }
    }
}
