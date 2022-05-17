using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IBLLBlog
    {
        Task<bool> AddOneBlog(Blog blog);
        /// <summary>
        /// 查询blog集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        List<Blog> Where(Expression<Func<Blog, bool>> expression);
        /// <summary>
        /// 查询一个blog
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Blog Find(Expression<Func<Blog, bool>> expression);
        /// <summary>
        /// 编辑blog
        /// </summary>
        /// <param name="editBlogs">内容集合</param>
        /// <returns></returns>
        Task<bool> UpdateBlog(List<Blog> editBlogs);
        /// <summary>
        /// 删除一个blog集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<bool> DeleteBlog(Expression<Func<Blog, bool>> expression);
    }
}
