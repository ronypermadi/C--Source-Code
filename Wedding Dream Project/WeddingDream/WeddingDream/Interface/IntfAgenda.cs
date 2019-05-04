using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeddingDream.Entity;

namespace WeddingDream.Interface
{
    interface IntfAgenda
    {
        DataSet viewAgenda();
        Boolean insertAgenda(EntAgenda ea);
        Boolean updateAgenda(EntAgenda ea, int id_agenda);
        Boolean deleteAgenda(int id_agenda);
    }
}
