﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VivazAPI.Models;

namespace VivazAPI.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected DataContext _context { get; }
        private DbSet<T> _dataset;

        public Repository(DataContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }

        public IEnumerable<T> FindAll()
        {
            return _dataset.ToList();
        }

        public T FindById(Guid id)
        {
            return _dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public void Create(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            
            _dataset.Add(entity);
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            _dataset.Update(entity);
        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            
            _dataset.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
        public bool Exists(Guid id)
        {
            return _dataset.Any(e => e.Id == id);
        }
    }
}