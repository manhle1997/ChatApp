using ChatApp.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services.Base
{
    public class BaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService(
            IBaseRepository<T> baseRepository
            ) 
        {
            _baseRepository = baseRepository;
        }
        Task<T> Add(T t)
        {
            return _baseRepository.Add( t );
        }
        Task<int> Update(int id, T t)
        {
            return _baseRepository.Update( id, t );
        }
        void Delete(int id)
        {
            _baseRepository.Delete( id );
        }
        Task<IEnumerable<T>> GetAll() 
        { 
            return _baseRepository.GetAll(); 
        }
        Task<T> GetById(int id)
        {
            return _baseRepository.GetById( id );
        }
        Task<int> SaveChanges()
        {
            return _baseRepository.SaveChanges();
        }
    }
}
