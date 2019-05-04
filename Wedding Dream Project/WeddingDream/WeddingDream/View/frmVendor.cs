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
    public partial class frmVendor : Form
    {
        private MySqlConnection koneksi;
        private ImpVendor impVendor;
        private EntVendor entVendor;
        private Boolean status;
        private int id_vendor;
        private int telp;

        public frmVendor()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impVendor = new ImpVendor();
            entVendor = new EntVendor();
            InitializeComponent();
            txtNamaVendor.Focus();
        }
        void viewVendor()
        {
            DataSet ds = impVendor.viewVendor();
            dgvVendor.DataSource = ds;
            dgvVendor.DataMember = "vendor";
        }
        private void dgvVendor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Hide();
            txtID.Show();
            txtID.Enabled = false;
            txtID.Text = dgvVendor.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaVendor.Text = dgvVendor.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAlamatVendor.Text = dgvVendor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelp.Text = dgvVendor.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEmail.Text = dgvVendor.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtWebsite.Text = dgvVendor.Rows[e.RowIndex].Cells[5].Value.ToString();

            id_vendor = Int16.Parse(txtID.Text);
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {
            txtID.Hide();
            viewVendor();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtNamaVendor.Text == "" || txtAlamatVendor.Text == "" || txtTelp.Text == "" || txtEmail.Text == "" || txtWebsite.Text == "")
            {
                MessageBox.Show("Form harus diisi !");
                txtNamaVendor.Focus();
            }
            else
            {
                telp = Int32.Parse(txtTelp.Text);
                entVendor.setNamaVendor(txtNamaVendor.Text);
                entVendor.setAlamatVendor(txtAlamatVendor.Text);
                entVendor.setEmail(txtEmail.Text);
                entVendor.setWebsite(txtWebsite.Text);
                entVendor.setTelp(telp);

                status = impVendor.insertVendor(entVendor);

                if (status == false)
                {
                    MessageBox.Show("Input Failed !!");
                    txtNamaVendor.Text = "";
                    txtAlamatVendor.Text = "";
                    txtEmail.Text = "";
                    txtTelp.Text = "";
                    txtWebsite.Text = "";
                    txtNamaVendor.Focus();
                }
                else
                {
                    MessageBox.Show("Input Success !!");
                    txtNamaVendor.Text = "";
                    txtAlamatVendor.Text = "";
                    txtEmail.Text = "";
                    txtTelp.Text = "";
                    txtWebsite.Text = "";
                    txtNamaVendor.Focus();
                }
                viewVendor();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (txtNamaVendor.Text == "" || txtAlamatVendor.Text == "" || txtTelp.Text == "" || txtEmail.Text == "" || txtWebsite.Text == "")
            {
                MessageBox.Show("Form harus diisi !");
                txtNamaVendor.Focus();
            }
            else
            {
                id_vendor = Int16.Parse(txtID.Text);
                telp = Int32.Parse(txtTelp.Text);
                entVendor.setNamaVendor(txtNamaVendor.Text);
                entVendor.setAlamatVendor(txtAlamatVendor.Text);
                entVendor.setEmail(txtEmail.Text);
                entVendor.setWebsite(txtWebsite.Text);
                entVendor.setTelp(telp);

                status = impVendor.updateVendor(entVendor, id_vendor);
                

                if (status == false)
                {
                    MessageBox.Show("Update Failed !!");
                    txtNamaVendor.Text = "";
                    txtAlamatVendor.Text = "";
                    txtEmail.Text = "";
                    txtTelp.Text = "";
                    txtWebsite.Text = "";
                    txtNamaVendor.Focus();
                }
                else
                {
                    MessageBox.Show("Update Success !!");
                    txtNamaVendor.Text = "";
                    txtAlamatVendor.Text = "";
                    txtEmail.Text = "";
                    txtTelp.Text = "";
                    txtWebsite.Text = "";
                    txtNamaVendor.Focus();
                }
                viewVendor();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            impVendor.deleteVendor(id_vendor);
            viewVendor();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNamaVendor.Text = "";
            txtAlamatVendor.Text = "";
            txtEmail.Text = "";
            txtTelp.Text = "";
            txtWebsite.Text = "";
            txtNamaVendor.Focus();
            lblID.Show();
            txtID.Hide();
        }
    }
}
