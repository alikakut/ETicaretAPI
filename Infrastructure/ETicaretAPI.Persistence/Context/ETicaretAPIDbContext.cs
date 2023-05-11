using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Context
{
    public class ETicaretAPIDbContext : DbContext
    {
        public ETicaretAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ETicaretAPIDbContext()
        {
        }
        public DbSet<Product>  products { get; set; }   
        public DbSet<Order> orders { get; set; }    
        public DbSet<Customer> customers { get; set; }
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
