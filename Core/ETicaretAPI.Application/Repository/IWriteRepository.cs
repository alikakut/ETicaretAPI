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
        Task<bool> RemoveAsync(int Id);
        bool Remove(T model,int id);
        bool Remove(List<T> data);
        bool DeleteById(long Id);
        Task<bool> AddAsync(T model);
        bool Add(T data);
        Task<int> SaveAsync();
    }
}
