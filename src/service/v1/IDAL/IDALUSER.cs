using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IDALUSER
    {

        int Login(string acc, string pwd);

        User GetOne(string acc);
    }
}
