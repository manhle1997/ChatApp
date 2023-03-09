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
        private readonly ChatAppContext _context;
        public BaseRepository(ChatAppContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T t)
        {
            var result = await _context.Set<T>().AddAsync(t);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async void Delete(int id)
        {
            var model = await GetById(id);
            if (model != null)
            {
                _context.Set<T>().Remove(model);
            }
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var result =  await _context.Set<T>().ToListAsync();
            return result;
        }

        public async Task<T> GetById(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Update(int id, T t)
        {
            var model = await GetById(id);
            if (model != null)
            {
                model = t;
                var result = _context.Set<T>().Update(model);
                return id;
            }
            return 0;
        }
    }
}
