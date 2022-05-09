using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace IDAL
{
    public interface IDALUser
    {

        int Login(string acc, string pwd);

        User Find(Expression<Func<User, bool>> expression);
    }
}
