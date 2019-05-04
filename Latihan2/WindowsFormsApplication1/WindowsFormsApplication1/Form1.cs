using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmSederhana : Form
    {
        public frmSederhana()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            if (radioLakiLaki.Checked==true)
            {
                MessageBox.Show("Hallo Bp. " + txtNama.Text);
            }
            if (radioPerempuan.Checked==true)
            {
                MessageBox.Show("Hallo Ibu. " + txtNama.Text);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            radioLakiLaki.Checked = false;
            radioPerempuan.Checked = false;
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
