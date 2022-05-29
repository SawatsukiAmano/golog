using BLL.Base;
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
    public class BLLBlogMySql : BaseBLL<Blog>, IBLLBlog
    {
        private readonly IBaseDAL<Blog> _dALBlog;
        public BLLBlogMySql(IBaseDAL<Blog> dal)
        {
            this._dALBlog = dal;
            base._baseDal= dal;
        }

    }
}
