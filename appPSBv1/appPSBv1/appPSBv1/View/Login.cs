using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace appPSBv1
{
    public partial class Login : Form
    {
        private MySqlConnection koneksiObj;
        private Boolean statuslogin;
        private Implement.ImpUser impuser;
        public Login(){
            impuser = new Implement.ImpUser();
            koneksiObj = KoneksiDB.Koneksi.GetKoneksi();
            try{
                koneksiObj.Open();
                //MessageBox.Show("Koneksi Sukses");
            }
            catch(MySqlException se){
                MessageBox.Show("Koneksi Gagal" + se);
            }
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e){
            if (txtUsername.Text==""||txtPassword.Text==""){
                MessageBox.Show("Username dan Password harus diisi!!!");
            }else{
                statuslogin = impuser.LoginUser(txtUsername.Text, txtPassword.Text);

                if (statuslogin==true){
                    View.FrmUser frmUser = new View.FrmUser();
                    frmUser.Show();
                }else{
                    MessageBox.Show("Maaf Login Gagal!!");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
