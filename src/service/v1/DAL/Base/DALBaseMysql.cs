using DBUtility;
using IBLL.Base;
using IDAL.Base;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Base
{
    public class DALBaseMysql<T> : IBaseDAL<T> where T : class, new()
    {
        private readonly EFMySqlContent _context;
        public DALBaseMysql()
        {
            _context = new EFMySqlContent();
        }


        #region DQL
        public async Task<T> FirstOrDefaultSync(Expression<Func<T, bool>> expression) => await Task.Run(() => { return _context.Set<T>().FirstOrDefault(expression); });
        public async Task<IList<T>> WhereSync(Expression<Func<T, bool>> expression) => await Task.Run(() => { return _context.Set<T>().Where(expression).ToList(); });
        public ValueTask<T> FindAsync(object id) => _context.Set<T>().FindAsync(id);
        #endregion

        #region DML
        public async Task<bool> UpdateSync(T newEntity) => await Task.Run(() =>
       {
           _context.Entry(newEntity).State = EntityState.Modified;
           return _context.SaveChanges() > 0;
       });
        public async Task<bool> AddSync(T entity) => await Task.Run(() =>
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges() > 0;
        });

        public async Task<bool> AddRangeSync(IList<T> entities) => await Task.Run(() =>
         {
             _context.Set<T>().AddRange(entities);
             return _context.SaveChanges() > 0;
         });

        public async Task<bool> DeleteSync(Expression<Func<T, bool>> expression) => await Task.Run(() =>
         {
             var removes = _context.Set<T>().Where(expression);
             _context.RemoveRange(removes);
             return _context.SaveChanges() > 0;
         });
        #endregion
    }
}
