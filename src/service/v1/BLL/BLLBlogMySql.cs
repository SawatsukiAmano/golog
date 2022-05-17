using IBLL;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public async Task<bool> DeleteBlog(Expression<Func<Blog, bool>> expression)
        {
            return await Task.Run(() =>
            {
                return _dALBlog.DeleteBlog(expression);
            });
        }

        public Blog Find(Expression<Func<Blog, bool>> expression)
        {
            return _dALBlog.Find(expression);
        }

        public async Task<bool> UpdateBlog(List<Blog> editBlogs)
        {
            return await Task.Run(() =>
            {
                return _dALBlog.UpdateBlog(editBlogs);
            });
        }

        public List<Blog> Where(Expression<Func<Blog, bool>> expression)
        {
            return _dALBlog.Where(expression);
        }
    }
}
