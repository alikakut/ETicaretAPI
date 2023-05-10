using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repository
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntity
    {
        bool Update(T entity);
        Task<bool> RemoveAsync(String Id);
        bool Remove(T model);
        bool Remove(List<T> data);
        Task<bool> AddAsync(T model);
        bool Add(List<T> data);
        Task<int> SaveAsync();
    }
}
