using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUser : IBLLUser
    {

        private readonly IDALUser _dalUser;

        public BLLUser(IDALUser userDAL)
        {
            this._dalUser = userDAL;

        }

        public User Find(Expression<Func<User, bool>> expression)
        {
            return _iUserDAL.Find(expression);
        }

        public bool Logion(string acc, string pwd)
        {
            bool result = false;

            return false;
        }
    }
}
