using DBUtility;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBlogMySql : IDALBlog
    {
        public bool AddOneBlog(Blog blog)
        {
            using (var db = new EFMySqlContent())
            {
                blog.BlogId = 0;
                db.Add(blog);
                return db.SaveChanges() > 0;
            }
        }

        public bool DeleteBlog(Expression<Func<Blog, bool>> expression)
        {
            using (var db = new EFMySqlContent())
            {
                var result = db.Blog.Where(expression);
                db.Blog.RemoveRange(result);
                return db.SaveChanges() > 0;
            }
        }

        public Blog Find(Expression<Func<Blog, bool>> expression)
        {
            using (var db = new EFMySqlContent())
            {
                var user = db.Blog.FirstOrDefault(expression);
                return user;
            }
        }

        public bool UpdateBlog(List<Blog> editBlog)
        {
            using (var db = new EFMySqlContent())
            {
                if (editBlog != null && editBlog.Count() > 0)
                {
                    var blogs = db.Blog.Where(b => editBlog.Any(e => e.BlogId == b.BlogId));
                    foreach (var item in editBlog)
                    {
                        var old = blogs.FirstOrDefault(o => o.BlogId == item.BlogId);
                        old = item;
                    }
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public List<Blog> Where(Expression<Func<Blog, bool>> expression)
        {
            using (var db = new EFMySqlContent())
            {
                var user = db.Blog.Where(expression).ToList();
                return user;
            }
        }
    }
}
