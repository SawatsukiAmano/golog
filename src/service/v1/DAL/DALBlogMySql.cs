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
    public class DALBlogMySql : EFMySqlContent<Blog>,IDALBlog
    {

    }
}
