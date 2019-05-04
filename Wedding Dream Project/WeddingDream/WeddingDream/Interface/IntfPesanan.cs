using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;

namespace WeddingDream.Interface
{
    interface IntfPesanan
    {
        int ViewID();
        DataSet viewPesanan();
        Boolean insertPesanan(EntPesanan ep);
        Boolean updatePesanan(EntPesanan ep, int id_pesanan);
        Boolean deletePesanan(int id_pesanan);
    }
}
