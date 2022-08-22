namespace BLL.Base
{
    public class BaseBLL<T> : IBLL.Base.IBaseBLL<T> where T : class
    {

        public IBaseDAL<T> _baseDal { get; set; }//通过在子类的构造函数中注入，这里是基类，不用构造函数

        #region DQL

        public async ValueTask<T> FindAsync(object id) => await _baseDal.FindAsync(id);

        public async Task<T> FirstOrDefaultSync(Expression<Func<T, bool>> expression) => await _baseDal.FirstOrDefaultSync(expression);
        public async Task<IList<T>> WhereSync(Expression<Func<T, bool>> expression) => await _baseDal.WhereSync(expression);

        #endregion

        #region DML
        public async Task<bool> AddRangeSync(IList<T> entities) => await _baseDal.AddRangeSync(entities);

        public async Task<bool> AddSync(T entity) => await _baseDal.AddSync(entity);

        public async Task<bool> DeleteSync(Expression<Func<T, bool>> expression) => await _baseDal.DeleteSync(expression);
        public async Task<bool> UpdateSync(T newEntity) => await _baseDal.UpdateSync(newEntity);


        #endregion



    }
}
