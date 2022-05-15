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
    public class BLLBlogMySql : IBLLBlog
    {
        private readonly IDALBlog _dALBlog;
        public BLLBlogMySql(IDALBlog blogDAL)
        {
            this._dALBlog = blogDAL;
        }
        public async Task<bool> AddOneBlog(Blog blog)
        {
            return await Task.Run(() =>
            {
                return _dALBlog.AddOneBlog(blog);
            });
        }
    }
}
