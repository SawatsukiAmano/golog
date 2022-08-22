namespace BLL.MySql
{
    public class BLLCommentMySql : BaseBLL<Comment>, IBLLComment
    {
        private readonly IBaseDAL<Comment> _dALComment;
        public BLLCommentMySql(IDALComment dal)
        {
            this._dALComment = dal;
            base._baseDal = dal;
        }
    }
}
