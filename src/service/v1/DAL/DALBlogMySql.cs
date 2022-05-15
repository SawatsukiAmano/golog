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
        public bool InsterOneBlog(Blog blog)
        {
            using (var db = new EFMySqlContent())
            {
                db.Add(blog);
                return db.SaveChanges() > 0;
            }

        }
    }
}
