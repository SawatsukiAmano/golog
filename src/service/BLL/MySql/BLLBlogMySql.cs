namespace BLL.MySql
{
    public class BLLBlogMySql : BaseBLL<Blog>, IBLLBlog
    {
        private readonly IBaseDAL<Blog> _dALBlog;
        public BLLBlogMySql(IDALBlog dal)
        {
            this._dALBlog = dal;
            base._baseDal= dal;
        }

    }
}
