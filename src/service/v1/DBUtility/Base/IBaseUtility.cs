using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DBUtility.Base
{
    public interface IBaseUtility<T> where T : class
    {
        /// <summary>
        /// 根据id获取一个实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetOneById(object id);
        /// <summary>
        /// 表达书获取一个实体
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        T FindOne(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 获取实体集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        T Where(Expression<Func<T, bool>> expression);

        bool AddOne(T model);

    }
}
