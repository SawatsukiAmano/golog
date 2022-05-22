using DBUtility;
using IDAL;
using IDAL.Base;
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

        public Blog FindOne(Expression<Func<Blog, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Blog GetOneById(object id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBlog(List<Blog> editBlog)
        {
            using (var db = new EFMySqlContent())
            {
                if (editBlog != null && editBlog.Count() > 0)
                {
                    int[] ids = editBlog.Select(p => p.BlogId).ToArray();
                    var blogs = db.Blog.Where(b => ids.Any(e => e == b.BlogId)).ToList();
                    foreach (var item in editBlog)
                    {
                        var old = blogs.FirstOrDefault(o => o.BlogId == item.BlogId);
                        old.BlogName = item.BlogName;
                        old.Category=item.Category;
                        old.ViewTxt = item.ViewTxt;
                        old.UserName = item.UserName;
                        old.CurrEditTxt = item.CurrEditTxt;
                        old.LatestTime=DateTime.Now;
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

        Blog IBaseDAL<Blog>.Where(Expression<Func<Blog, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
