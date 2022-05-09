using IDAL;
using DBUtility;
using Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DAL
{
    public class DALUserMySql : IDALUser
    {

        public User Find(Expression<Func<User, bool>> expression)
        {
            using (var db = new EFMySqlContent())
            {
                var user = db.User.Where(expression).FirstOrDefault();
                return user;
            }
        }

        public int Login(string acc, string pwd)
        {
            int result = 0;

            return result;
        }
    }
}
