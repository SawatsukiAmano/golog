using IDAL;
using DBUtility;
using Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUSER : IDALUSER
    {
        public User GetOne(string acc)
        {
            using (var db = new EFMySQLContent())
            {

            }
        }

        public int Login(string acc, string pwd)
        {
            int result = 0;

            return result;
        }
    }
}
