using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUser : IBLLUser
    {

        private IDALUSER _iUserDAL;

        public BLLUser(IDALUSER userDAL)
        {
            this._iUserDAL = userDAL;

        }

        public User GetOne(string acc)
        {

        }

        public bool Logion(string acc, string pwd)
        {
            bool result = false;


            return false;
        }
    }
}
