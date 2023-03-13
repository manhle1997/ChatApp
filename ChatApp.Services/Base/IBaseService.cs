using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services
{
    public interface IBaseService<T> where T : class
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);
        IQueryable<T> GetAll();
        T? GetById(int id);
        T? GetById(long id);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        bool Any(Expression<Func<T, bool>> where);
        int SaveChanges();
    }
}
