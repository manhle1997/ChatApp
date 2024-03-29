﻿using ChatApp.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Services.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
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
            _baseRepository.Delete(where);
        }
        public IQueryable<T> GetAll()
        {
            return _baseRepository.GetAll();
        }
        public T? GetById(int id)
        {
            return _baseRepository.GetById(id);
        }
        public T? GetById(long id)
        {
            return _baseRepository.GetById(id);
        }
        public IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return _baseRepository.GetMany(where);
        }
        public bool Any(Expression<Func<T, bool>> where)
        {
            return _baseRepository.Any(where);
        }
        public int SaveChanges()
        {
            return _baseRepository.SaveChanges();
        }
    }
}
