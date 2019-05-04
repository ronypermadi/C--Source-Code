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
    public partial class frmCekID : Form
    {
        
        private ImpCekID impCekID;
        private MySqlConnection koneksi;
        

        public frmCekID()
        {
            koneksi = KoneksiDB.Koneksi.getKoneksi();
            impCekID = new ImpCekID();
            InitializeComponent();  
        }
        public frmCekID(String key) : this(){
            DataSet ds = impCekID.viewCekID(key);
            dgvCekID.DataSource = ds;
            dgvCekID.DataMember = key;
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCekID_Load(object sender, EventArgs e)
        {
            
        }
    }
}
