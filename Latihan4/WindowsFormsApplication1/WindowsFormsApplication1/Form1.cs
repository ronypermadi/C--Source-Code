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
    public partial class FrmDataMahasiswa : Form
    {
        public FrmDataMahasiswa()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int baris = 0;
            dgvMahasiswa.Rows.Add();
            baris = dgvMahasiswa.Rows.Count - 2;

            String jk;
            if (rdbLaki.Checked==true)
            {
                jk = "Laki - Laki";
            }else
            {
                jk = "Perempuan";
            }

            dgvMahasiswa[0, baris].Value = dgvMahasiswa.Rows.Count - 1;
            dgvMahasiswa[1, baris].Value = txtNIM.Text;
            dgvMahasiswa[2, baris].Value = txtNama.Text;
            dgvMahasiswa[3, baris].Value = jk;
            dgvMahasiswa[4, baris].Value = txtTempatlahir.Text;
            dgvMahasiswa[5, baris].Value = dtpTanggallahir.Text;
            dgvMahasiswa[6, baris].Value = txtAlamat.Text;
            dgvMahasiswa[7, baris].Value = cmbProdi.SelectedItem.ToString();

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvMahasiswa.SelectedRows.Count>0)
            {
                dgvMahasiswa.Rows.RemoveAt(this.dgvMahasiswa.SelectedRows[0].Index);
            }
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
