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
    public partial class frmAgenda : Form
    {
        private MySqlConnection koneksi;
        private ImpAgenda impAgenda;
        private ImpCustomer impCustomer;
        private EntAgenda entAgenda;
        private Boolean status;
        private int id_agenda;
        private int id_customer;

        public frmAgenda()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impAgenda = new ImpAgenda();
            impCustomer = new ImpCustomer();
            entAgenda = new EntAgenda();
            InitializeComponent();
            cmbCustomer();
        }

        void cmbCustomer()
        {
            DataTable dt = impCustomer.cmbCustomer();
            CmbViewCustomer.DataSource = dt;
            CmbViewCustomer.ValueMember = "id_customer";
            CmbViewCustomer.DisplayMember = "id_customer";
        }
        void viewAgenda()
        {
            DataSet ds = impAgenda.viewAgenda();
            dgvAgenda.DataSource = ds;
            dgvAgenda.DataMember = "agenda";
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            txtID.Hide();
            viewAgenda();
            CmbViewCustomer.Text = "";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtAcara.Text == "" || CmbViewCustomer.Text == "" || txtTempat.Text == "" || dtpTgl.Checked == false)
            {
                MessageBox.Show("Form harus diisi !");
                CmbViewCustomer.Focus();
            }
            else
            {
                id_customer = Int32.Parse(CmbViewCustomer.Text);
                entAgenda.setJudul(txtAcara.Text);
                entAgenda.setIDCustomer(id_customer);
                entAgenda.setTempat(txtTempat.Text);
                entAgenda.setTgl(dtpTgl.Text);

                status = impAgenda.insertAgenda(entAgenda);

                if (status == false)
                {
                    MessageBox.Show("Input Failed !!");
                    CmbViewCustomer.Text = "";
                    txtAcara.Text = "";
                    txtTempat.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Text = "";
                    CmbViewCustomer.Focus();
                }
                else
                {
                    MessageBox.Show("Input Success !!");
                    CmbViewCustomer.Text = "";
                    txtAcara.Text = "";
                    txtTempat.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Text = "";
                    CmbViewCustomer.Focus();
                }
                viewAgenda();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (txtAcara.Text == "" || CmbViewCustomer.Text == "" || txtTempat.Text == "" || dtpTgl.Checked == false)
            {
                MessageBox.Show("Form harus diisi !");
                CmbViewCustomer.Focus();
            }
            else
            {
                id_agenda = Int32.Parse(txtID.Text);
                id_customer = Int32.Parse(CmbViewCustomer.Text);
                entAgenda.setIDCustomer(id_customer);
                entAgenda.setJudul(txtAcara.Text);
                entAgenda.setTempat(txtTempat.Text);
                entAgenda.setTgl(dtpTgl.Text);

                status = impAgenda.updateAgenda(entAgenda, id_agenda);

                if (status == false)
                {
                    MessageBox.Show("Update Failed !!");
                    CmbViewCustomer.Text = "";
                    txtAcara.Text = "";
                    txtTempat.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Text = "";
                    CmbViewCustomer.Focus();
                }
                else
                {
                    MessageBox.Show("Update Success !!");
                    CmbViewCustomer.Text = "";
                    txtAcara.Text = "";
                    txtTempat.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Text = "";
                    CmbViewCustomer.Focus();
                }
                viewAgenda();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            impAgenda.deleteAgenda(id_agenda);
            viewAgenda();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAcara.Text = "";
            txtTempat.Text = "";
            dtpTgl.Checked = false;
            CmbViewCustomer.Text = "";
            CmbViewCustomer.Focus();
            lblID.Show();
            txtID.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Hide();
            txtID.Show();
            txtID.Enabled = false;
            dtpTgl.Checked = true;
            txtID.Text = dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString();
            CmbViewCustomer.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtAcara.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTempat.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();

            id_agenda = Int16.Parse(txtID.Text);
        }

        private void btnCekID_Click(object sender, EventArgs e)
        {
            String key = "customer";
            frmCekID cek = new frmCekID(key);
            cek.Show();
        }
    }
}
