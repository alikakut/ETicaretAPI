using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Application.Repository
{
    public interface IReadRepository<T> :IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true );
        IQueryable<T> GetWhere(Expression<Func<T,bool>>method, bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T,bool>>method, bool tracking = true);
        Task<T> GetByIdAsync(string id,bool tracking = true);
        Task<T> Add(T entity);
    }
}
