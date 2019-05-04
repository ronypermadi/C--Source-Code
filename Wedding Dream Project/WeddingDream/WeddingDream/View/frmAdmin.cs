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

namespace WeddingDream.View
{
    public partial class frmAdmin : Form
    {

        public frmAdmin()
        {
           InitializeComponent();
        }

        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();

            this.Hide();

        }

        private void btnUser_Click(object sender, EventArgs e)
        {
                       
            frmUser u = new frmUser();
            u.Show();

            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer c = new frmCustomer();
            c.Show();

            this.Hide();
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            frmPaket p = new frmPaket();
            p.Show();

            this.Hide();
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            frmVendor v = new frmVendor();
            v.Show();

            this.Hide();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            l.Show();

            this.Hide();
        }

        private void btnPesanan_Click(object sender, EventArgs e)
        {
            frmPesanan p = new frmPesanan();
            p.Show();

            this.Hide();
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda a = new frmAgenda();
            a.Show();

            this.Hide();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            frmDetail d = new frmDetail();
            d.Show();

            this.Hide();
        }
    }
}
