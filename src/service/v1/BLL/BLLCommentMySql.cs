using BLL.Base;
using IBLL;
using IDAL.Base;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class BLLCommentMySql : BaseBLL<Comment>, IBLLComment
    {
        private readonly IBaseDAL<Comment> _dALComment;
        public BLLCommentMySql(IDAL.Base.IBaseDAL<Comment> dal)
        {
            this._dALComment = dal;
            base._baseDal = dal;
        }
    }
}
