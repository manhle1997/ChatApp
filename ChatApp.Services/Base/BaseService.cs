using ChatApp.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services.Base
{
    public class BaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService
            (IBaseRepository<T> baseRepository
            )
        {
            _baseRepository = baseRepository;
        }
        public void Add(T t)
        {
            _baseRepository.Add(t);
        }
        public void Update(T t)
        {
            _baseRepository.Update(t);
        }
        public void Delete(T t)
        {
            _baseRepository.Delete(t);
        }
        public void Delete(Expression<Func<T, bool>> where)
        {
            
        }
        public IQueryable<T> GetAll()
        {
            return _baseRepository.GetAll();
        }
        public T? GetById(int id)
        {
            return _baseRepository.GetById(id);
        }
        public int SaveChanges()
        {
            return _baseRepository.SaveChanges();
        }
    }
}
