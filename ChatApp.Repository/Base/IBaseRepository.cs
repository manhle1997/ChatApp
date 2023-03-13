using System.Linq.Expressions;

namespace ChatApp.Repository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        void Delete(Expression<Func<T, bool>> where);
        IQueryable<T> GetAll();
        T? GetById(int id);
        T? GetById(long id);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        bool Any(Expression<Func<T, bool>> where);
        int SaveChanges();
    }
}
