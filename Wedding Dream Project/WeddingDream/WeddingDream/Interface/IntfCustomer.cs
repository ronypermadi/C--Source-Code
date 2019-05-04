using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;

namespace WeddingDream.Interface
{
    interface IntfCustomer
    {
        DataTable cmbCustomer();
        DataSet viewCustomer();
        Boolean insertCustomer(EntCustomer ec);
        Boolean updateCustomer(EntCustomer ec, int id_customer);
        Boolean deleteCustomer(int id_customer);
    }
}
