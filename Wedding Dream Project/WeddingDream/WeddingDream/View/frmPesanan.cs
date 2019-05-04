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
    public partial class frmPesanan : Form
    {
        private MySqlConnection koneksi;
        private ImpPesanan impPesanan;
        private ImpCustomer impCustomer;
        private ImpPaket impPaket;
        private EntPesanan entPesanan;
        private Boolean status;
        private int id_pesanan;
        private int id_customer;
        private int id_paket;
        

        public frmPesanan()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impPesanan = new ImpPesanan();
            impCustomer = new ImpCustomer();
            impPaket = new ImpPaket();
            entPesanan = new EntPesanan();
            InitializeComponent();
            CmbViewCustomer.Focus();
            cmbCustomer();
            cmbPaket();
        }

        void cmbCustomer()
        {
            DataTable dt = impCustomer.cmbCustomer();
            CmbViewCustomer.DataSource = dt;
            CmbViewCustomer.ValueMember = "id_customer";
            CmbViewCustomer.DisplayMember = "id_customer";
        }

        void cmbPaket()
        {
            DataTable dt = impPaket.cmbPaket();
            CmbViewPaket.DataSource = dt;
            CmbViewPaket.ValueMember = "id_paket";
            CmbViewPaket.DisplayMember = "id_paket";
        }

        void viewPesanan()
        {
            DataSet ds = impPesanan.viewPesanan();
            dgvPesanan.DataSource = ds;
            dgvPesanan.DataMember = "pesanan";
        }

        private void frmPesanan_Load(object sender, EventArgs e)
        {
            CmbViewCustomer.Text = "";
            CmbViewPaket.Text = "";
            viewPesanan();
            txtID.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblID.Show();
            txtID.Hide();
            CmbViewCustomer.Text = "";
            CmbViewPaket.Text = "";
            dtpTgl.Checked = false;
            CmbViewCustomer.Focus();
        }

        private void btnCekID_Click(object sender, EventArgs e)
        {
            String key = "customer";
            frmCekID cek = new frmCekID(key);
            cek.Show();
        }

        private void btnCekID2_Click(object sender, EventArgs e)
        {
            String key = "paket";
            frmCekID cek = new frmCekID(key);
            cek.Show();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (CmbViewCustomer.Text == "" || CmbViewPaket.Text == "" || dtpTgl.Checked==false)
            {
                MessageBox.Show("Form harus diisi !");
                CmbViewCustomer.Focus();
            }
            else
            {
                id_customer = Int32.Parse(CmbViewCustomer.Text);
                id_paket = Int32.Parse(CmbViewPaket.Text);
                entPesanan.setIDCustomer(id_customer);
                entPesanan.setIDPaket(id_paket);
                entPesanan.setTgl(dtpTgl.Text);

                status = impPesanan.insertPesanan(entPesanan);

                if (status == false)
                {
                    MessageBox.Show("Input Failed !!");
                    CmbViewCustomer.Text = "";
                    CmbViewPaket.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Focus();
                }
                else
                {
                    MessageBox.Show("Input Success !!");
                    CmbViewCustomer.Text = "";
                    CmbViewPaket.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Focus();
                }
                viewPesanan();
            }
        }

        private void dgvPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Hide();
            txtID.Show();
            txtID.Enabled = false;
            dtpTgl.Checked = true;
            txtID.Text = dgvPesanan.Rows[e.RowIndex].Cells[0].Value.ToString();
            CmbViewCustomer.Text = dgvPesanan.Rows[e.RowIndex].Cells[1].Value.ToString();
            CmbViewPaket.Text = dgvPesanan.Rows[e.RowIndex].Cells[2].Value.ToString();
            //dtpTgl.Text = dgvPesanan.Rows[e.RowIndex].Cells[3].Value.ToString();
            

            id_pesanan = Int16.Parse(txtID.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            if (CmbViewCustomer.Text == "" || CmbViewPaket.Text == "" || dtpTgl.Checked == false)
            {
                MessageBox.Show("Form harus diisi !");
                CmbViewCustomer.Focus();
            }
            else
            {
                id_pesanan = Int16.Parse(txtID.Text);
                id_customer = Int16.Parse(CmbViewCustomer.Text);
                id_paket = Int16.Parse(CmbViewPaket.Text);
                entPesanan.setIDCustomer(id_customer);
                entPesanan.setIDPaket(id_paket);
                entPesanan.setTgl(dtpTgl.Text);

                status = impPesanan.updatePesanan(entPesanan, id_pesanan);

                if (status == false)
                {
                    MessageBox.Show("Update Failed !!");
                    CmbViewCustomer.Text = "";
                    CmbViewPaket.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Focus();
                }
                else
                {
                    MessageBox.Show("Update Success !!");
                    CmbViewCustomer.Text = "";
                    CmbViewPaket.Text = "";
                    dtpTgl.Checked = false;
                    CmbViewCustomer.Focus();
                }
                viewPesanan();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            impPesanan.deletePesanan(id_pesanan);
            viewPesanan();
        }
    }
}
