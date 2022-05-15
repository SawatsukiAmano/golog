using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBLLBlog
    {
        Task<bool> AddOneBlog(Blog blog);
    }
}
