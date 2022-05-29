using IBLL;
using IDAL;
using IDAL.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUserMySql : Base.BaseBLL<Model.User>, IBLLUser
    {

        private readonly IBaseDAL<User> _dalUser;


        public BLLUserMySql(IDALUser dal)
        {
            this._dalUser = dal;
            base._baseDal= dal;

        }
   
    }
}
