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
using WeddingDream.Implement;

namespace WeddingDream.View
{
    public partial class frmDetail : Form
    {
        private MySqlConnection koneksi;
        private ImpDetail impDetail;
        private ImpCustomer impCustomer;

        public frmDetail()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impDetail = new ImpDetail();
            impCustomer = new ImpCustomer();
            InitializeComponent();
            cmbCustomer();
        }

        void cmbCustomer()
        {
            DataTable dt = impCustomer.cmbCustomer();
            cmbDetail.DataSource = dt;
            cmbDetail.ValueMember = "id_customer";
            cmbDetail.DisplayMember = "nama_customer";
        }

        void viewDetail()
        {
            DataTable dt = impDetail.viewDetailID(cmbDetail.Text);
            dgvDetail.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmAdmin a = new frmAdmin();
            a.Show();

            this.Hide();
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDetailCus_Click(object sender, EventArgs e)
        {
            if (cmbDetail.Text == "")
            {
                MessageBox.Show("Silahkan Pilih Nama Customer");
            }
            else {
                viewDetail();
            }
        }
    }
}
