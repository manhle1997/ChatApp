using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<T> Add(T t);
        Task<int> Update(int id, T t);
        void Delete(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<int> SaveChanges();
    }
}
