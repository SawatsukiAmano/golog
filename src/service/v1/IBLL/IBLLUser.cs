using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBLLUser
    {
        bool Logion(string acc, string pwd);

        User GetOne(string acc);
    }
}
