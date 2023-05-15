﻿using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repository;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaretAPI.Persistence.Repository
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIDbContext _context;
        public WriteRepository(ETicaretAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(model);
            return entityEntry.State==EntityState.Added;
        }
        public bool Add(List<T> data)
        {
            Table.AddRange(data);
            return true;
        }

        public bool Remove(T model)
        {
          EntityEntry<T> entityEntry = Table.Remove(model);
           return entityEntry.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string Id)
        {
           T model = await Table.FirstOrDefaultAsync(data => data.Id == int.Parse(Id));
           return Remove(model);
        }

        public bool Remove(List<T> data)
        {
           Table.RemoveRange(data);
            return true;
        }
        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
    
    }
}
