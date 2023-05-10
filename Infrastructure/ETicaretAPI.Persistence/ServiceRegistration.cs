using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repository.Customers;
using ETicaretAPI.Application.Repository.Orders;
using ETicaretAPI.Application.Repository.Products;
using ETicaretAPI.Persistence.Context;
using ETicaretAPI.Persistence.Repository.Customers;
using ETicaretAPI.Persistence.Repository.Orders;
using ETicaretAPI.Persistence.Repository.products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceService(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionStrings),ServiceLifetime.Singleton);
            services.AddScoped<ICustomerReadRepository ,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository ,CustomerWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository ,ProductWriteRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        }
    }
}
