namespace DAL.Base
{
    public class DALBaseMysql<T> : IBaseDAL<T> where T : class, new()
    {
        private readonly EFMySqlContent _context;
        public DALBaseMysql()
        {
            _context = new EFMySqlContent();
        }

        #region DQL Sync
        public async Task<T> FirstOrDefaultSync(Expression<Func<T, bool>> expression) => await Task.Run(() => { return _context.Set<T>().FirstOrDefault(expression); });
        public async Task<IList<T>> WhereSync(Expression<Func<T, bool>> expression) => await Task.Run(() => { return _context.Set<T>().Where(expression).ToList(); });
        public async Task<IList<T>> WhereSync(Expression<Func<T, bool>> expressionFunc, Expression<Func<T, bool>> expressionSort) => await Task.Run(() => { return _context.Set<T>().Where(expressionFunc).OrderBy(expressionSort).ToList(); });
        public async Task<IList<M>> WhereSync<M>(Expression<Func<T, bool>> expressionFunc, Expression<Func<T, bool>> expressionSort, Expression<Func<T, M>> expressionSelect) => await Task.Run(() => { return _context.Set<T>().Where(expressionFunc).OrderBy(expressionSort).Select(expressionSelect).ToList(); });
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
