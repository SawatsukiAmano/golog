using DBUtility;
using IDAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
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
                blog.UserName = "122";
                blog.CreateTime = DateTime.Now;
                blog.LatestTime = DateTime.Now;
                db.Add(blog);
                return db.SaveChanges() > 0;
            }

        }
    }
}
