using System;
using System.Collections.Generic;
using System.Linq;
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
        int SaveChanges();
    }
}
