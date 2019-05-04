using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WeddingDream.Entity;

namespace WeddingDream.Interface
{
    interface IntfUser
    {
        Boolean Login(EntUser eu);
        DataSet viewUser();
        Boolean insertUser(EntUser eu);
        Boolean updateUser(EntUser eu, int id_user);
        Boolean deleteUser(int id_user);
    }
}
