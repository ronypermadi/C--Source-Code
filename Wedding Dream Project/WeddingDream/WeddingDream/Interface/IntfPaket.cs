using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;

namespace WeddingDream.Interface
{
    interface IntfPaket
    {
        DataTable cmbPaket();
        DataSet viewPaket();
        Boolean insertPaket(EntPaket ep);
        Boolean updatePaket(EntPaket ep, int id_paket);
        Boolean deletePaket(int id_paket);
    }
}
