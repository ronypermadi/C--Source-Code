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
        
       
        private void btnTambah_Click(object sender, EventArgs e)
        {
            lsbMatkul2.Items.Add(lsbMatkul1.SelectedItem.ToString());

            lsbMatkul1.Items.Remove(lsbMatkul1.SelectedItem.ToString());
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            lsbMatkul1.Items.Add(lsbMatkul2.SelectedItem.ToString());

            lsbMatkul2.Items.Remove(lsbMatkul2.SelectedItem.ToString());
        }

         private void btnCetakKrs_Click(object sender, EventArgs e)
        {
            if (rdbLakiLaki.Checked == true)
            {
                MessageBox.Show(
                "=========================\n" +
                "Biodata Mahasiswa\n" +
                "=========================\n" +
                "Nama\t\t" + txtNama.Text +
                "\nNIM\t\t" + txtNim.Text +
                "\nProgram Studi\t" + cmbProgramStudi.SelectedItem.ToString() +
                "\nProdi\t\t" + cmbProdi.SelectedItem.ToString() +
                "\nJenis Kelamin\t" + "Laki - Laki " +
                "\nAlamat\t\t" + richtxtAlamat.Text +
                "\nNo HP\t\t" + txtNohp.Text +
                "\n=========================" +
                "\nMata Kuliah Yang Telah Pilih" +
                "\n=========================" +
                "\n"+ lsbMatkul2.Items[0].ToString() +
                "\n" + lsbMatkul2.Items[1].ToString() +
                "\n" + lsbMatkul2.Items[2].ToString() +
                "\n" + lsbMatkul2.Items[3].ToString() +
                "\n" + lsbMatkul2.Items[4].ToString() +
                "\n" + lsbMatkul2.Items[5].ToString() +
                "\n" + lsbMatkul2.Items[6].ToString() +
                "\n" + lsbMatkul2.Items[7].ToString() +
                "\n" + lsbMatkul2.Items[8].ToString()
                );

            }

            if (rdbPerempuan.Checked == true)
            {
                MessageBox.Show(
                "=========================\n" +
                "Biodata Mahasiswa\n" +
                "=========================\n" +
                "Nama\t\t" + txtNama.Text +
                "\nNIM\t\t" + txtNim.Text +
                "\nProgram Studi\t" + cmbProgramStudi.SelectedItem.ToString() +
                "\nProdi\t\t" + cmbProdi.SelectedItem.ToString() +
                "\nJenis Kelamin\t" + "Perempuan " +
                "\nAlamat\t\t" + richtxtAlamat.Text +
                "\nNo HP\t\t" + txtNohp.Text +
                "\n=========================" +
                "\nMata Kuliah Yang Telah Pilih" +
                "\n=========================" +
                "\n" + lsbMatkul2.Items[0].ToString() +
                "\n" + lsbMatkul2.Items[1].ToString() +
                "\n" + lsbMatkul2.Items[2].ToString() +
                "\n" + lsbMatkul2.Items[3].ToString() +
                "\n" + lsbMatkul2.Items[4].ToString() +
                "\n" + lsbMatkul2.Items[5].ToString() +
                "\n" + lsbMatkul2.Items[6].ToString() +
                "\n" + lsbMatkul2.Items[7].ToString() +
                "\n" + lsbMatkul2.Items[8].ToString()
                );

            }


        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
