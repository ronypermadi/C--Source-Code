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
    public partial class frmPaket : Form
    {
        private MySqlConnection koneksi;
        private ImpPaket impPaket;
        private ImpVendor impVendor;
        private EntPaket entPaket;
        private Boolean status;
        private int id_paket;
        private int harga;
        private int id_vendor;


        public frmPaket()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impPaket = new ImpPaket();
            impVendor = new ImpVendor();
            entPaket = new EntPaket();
            InitializeComponent();
            cmbVendor();
            CmbViewVendor.Focus();
        }
        void cmbVendor()
        {
            DataTable dt = impVendor.cmbVendor();
            CmbViewVendor.DataSource = dt;
            CmbViewVendor.ValueMember = "id_vendor";
            CmbViewVendor.DisplayMember = "id_vendor";
        }
        void viewPaket()
        {
            DataSet ds = impPaket.viewPaket();
            dgvPaket.DataSource = ds;
            dgvPaket.DataMember = "paket";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }

        private void frmPaket_Load(object sender, EventArgs e)
        {
            txtID.Hide();
            CmbViewVendor.Text = "";
            viewPaket();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            if (txtNamaPaket.Text == "" || txtHarga.Text == "" || CmbViewVendor.Text == "")
            {
                MessageBox.Show("Form harus diisi !");
                CmbViewVendor.Focus();
            }
            else
            {
                id_vendor = Int32.Parse(CmbViewVendor.Text);
                harga = Int32.Parse(txtHarga.Text);
                entPaket.setNamaPaket(txtNamaPaket.Text);
                entPaket.setHarga(harga);
                entPaket.setIDVendor(id_vendor);

                status = impPaket.insertPaket(entPaket);

                if (status == false)
                {
                    MessageBox.Show("Input Failed !!");
                    txtNamaPaket.Text = "";
                    txtHarga.Text = "";
                    CmbViewVendor.Text = "";
                    CmbViewVendor.Focus();
                }
                else
                {
                    MessageBox.Show("Input Success !!");
                    txtNamaPaket.Text = "";
                    txtHarga.Text = "";
                    CmbViewVendor.Text = "";
                    CmbViewVendor.Focus();
                }
                viewPaket();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (txtNamaPaket.Text == "" || txtHarga.Text == "" || CmbViewVendor.Text == "")
            {
                MessageBox.Show("Form harus diisi !");
                CmbViewVendor.Focus();
            }
            else
            {
                id_paket = Int16.Parse(txtID.Text);
                harga = Int32.Parse(txtHarga.Text);
                id_vendor = Int32.Parse(CmbViewVendor.Text);
                entPaket.setNamaPaket(txtNamaPaket.Text);
                entPaket.setHarga(harga);
                entPaket.setIDVendor(id_vendor);

                status = impPaket.updatePaket(entPaket, id_paket);

                if (status == false)
                {
                    MessageBox.Show("Update Failed !!");
                    txtNamaPaket.Text = "";
                    txtHarga.Text = "";
                    CmbViewVendor.Text = "";
                    CmbViewVendor.Focus();
                }
                else
                {
                    MessageBox.Show("Update Success !!");
                    txtNamaPaket.Text = "";
                    txtHarga.Text = "";
                    CmbViewVendor.Text = "";
                    CmbViewVendor.Focus();
                }
                viewPaket();
            }
        }

        private void dgvPaket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Hide();
            txtID.Show();
            txtID.Enabled = false;
            txtID.Text = dgvPaket.Rows[e.RowIndex].Cells[0].Value.ToString();
            CmbViewVendor.Text = dgvPaket.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNamaPaket.Text = dgvPaket.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHarga.Text = dgvPaket.Rows[e.RowIndex].Cells[3].Value.ToString();

            id_paket = Int16.Parse(txtID.Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            impPaket.deletePaket(id_paket);
            viewPaket();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHarga.Text = "";
            txtNamaPaket.Text = "";
            CmbViewVendor.Text = "";
            CmbViewVendor.Focus();
            lblID.Show();
            txtID.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String key = "vendor";
            frmCekID cek = new frmCekID(key);
            cek.Show();
        }
    }
}
