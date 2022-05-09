using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace IBLL
{
    public interface IBLLUser
    {
        bool Logion(string acc, string pwd);

        User Find(Expression<Func<User, bool>> expression);
    }
}
