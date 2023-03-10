using ChatApp.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Repository.Base
{
    public class BaseRepository<T> where T : class
    {
        private ChatAppContext _context;
        
        public BaseRepository(ChatAppContext context)
        {
            _context = context;
        }

        public void Add(T t)
        {
            _context.Set<T>().Add(t);
        }

        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
        }

        public IQueryable<T> GetAll()
        {
            var result = _context.Set<T>();
            return result;
        }

        public T? GetById(int id)
        {
            return _context.Set<T>().Find(id);
            
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Entry(t).State = EntityState.Modified;
        }
    }
}
