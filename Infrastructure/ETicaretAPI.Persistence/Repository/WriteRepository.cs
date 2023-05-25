using System;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public bool Add(T data)
        {
            Table.AddRange(data);
            _context.SaveChanges();
            return true;
        }

        public bool Remove(T model, int id)
        {
            model.Id = id;
            EntityEntry<T> entityEntry = Table.Remove(model);
            _context.SaveChanges();
            return entityEntry.State == EntityState.Deleted;
        }
        public async Task<bool> RemoveAsync(int Id)
        {
           T model = await Table.FirstOrDefaultAsync(data => data.Id == Id);
           return Remove(model,Id);
        }

        public bool Remove(List<T> data)
        {
            Table.RemoveRange(data);
            return true;
        }
        public bool Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            _context.SaveChanges();
            return entityEntry.State == EntityState.Modified;
        }
        public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();

        //public bool DeleteById(long Id)
        //{
        //    return true;
        //}

        public bool DeleteById(long Id)
        {
            var dbContext = new ETicaretAPIDbContext();

            try
            {
                var entity = dbContext.orders.FirstOrDefault(e => e.Id == Id);

                if (entity != null)
                {
                    dbContext.orders.Remove(entity);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
            finally
            {
                dbContext.Dispose();
            }
        }


    }
}
