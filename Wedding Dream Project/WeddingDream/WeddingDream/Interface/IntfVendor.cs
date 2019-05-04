using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;

namespace WeddingDream.Interface
{
    interface IntfVendor
    {
        DataTable cmbVendor();
        DataSet viewVendor();
        Boolean insertVendor(EntVendor ev);
        Boolean updateVendor(EntVendor ev, int id_vendor);
        Boolean deleteVendor(int id_vendor);
    }
}
