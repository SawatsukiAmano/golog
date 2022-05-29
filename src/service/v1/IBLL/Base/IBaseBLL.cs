using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IBLL.Base
{
    public interface IBaseBLL<T> where T : class
    {

        #region DQL
        /// <summary>
        /// 键值对
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ValueTask<T> FindAsync(object id);
        /// <summary>
        /// 查询单个实体
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<T> FirstOrDefaultSync(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 查询集合
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<IList<T>> WhereSync(Expression<Func<T, bool>> expression);
        #endregion

        #region DML
        /// <summary>
        /// 新增一个实体
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> AddSync(T entity);
        /// <summary>
        /// 新增实体集合
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<bool> AddRangeSync(IList<T> entities);
        /// <summary>
        /// 删除实体集合
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<bool> DeleteSync(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 更新一个实体
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newEntity"></param>
        /// <returns></returns>
        Task<bool> UpdateSync(T newEntity);
        #endregion

    }
}
