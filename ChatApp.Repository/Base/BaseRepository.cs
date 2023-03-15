using ChatApp.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ChatAppContext _context;
        private readonly DbSet<T> _dbSet;
        
        public BaseRepository(ChatAppContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T t)
        {
            _context.Set<T>().Add(t);
            _context.Entry(t).State = EntityState.Added;
        }

        public void Delete(T t)
        {
            _context.Set<T>().Remove(t);
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = _context.Set<T>().Where(where).AsEnumerable();  
            foreach (T obj in objects)
            {
                _dbSet.Remove(obj);
            }
        }

        public IQueryable<T> GetAll()
        {            
            return _dbSet;
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);
            
        }
        public T? GetById(long id)
        {
            return _dbSet.Find(id);
        }
        public IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _dbSet.Where(where);
        }
        public bool Any(Expression<Func<T, bool>> where)
        {
            return _dbSet.Any(where);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(T t)
        {
           _dbSet.Attach(t);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                _context = null;
            }
        }
    }
}
