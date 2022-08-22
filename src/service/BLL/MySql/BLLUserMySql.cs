namespace BLL.MySql
{
    public class BLLUserMySql : Base.BaseBLL<Model.User>, IBLLUser
    {
        private readonly IBaseDAL<User> _dALUser;
        public BLLUserMySql(IDALUser dal)
        {
            this._dALUser = dal;
            base._baseDal = dal;
        }
    }
}
