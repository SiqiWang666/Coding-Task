using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Siqi.CabBooking.Core.RepositoryInterfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IEnumerable<T>> ListAllAsync();
        Task<IEnumerable<T>> FilterAllAsync(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}