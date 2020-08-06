using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Infrastructure.Data;

namespace Siqi.CabBooking.Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly CabBookingDbContext _cabBookingDbContext;

        public EfRepository(CabBookingDbContext cabBookingDbContext)
        {
            _cabBookingDbContext = cabBookingDbContext;
        }

        public virtual async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _cabBookingDbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<IEnumerable<T>> FilterAllAsync(Expression<Func<T, bool>> filter)
        {
            return await _cabBookingDbContext.Set<T>().Where(filter).ToListAsync();
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _cabBookingDbContext.Set<T>().AddAsync(entity);
            await _cabBookingDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _cabBookingDbContext.Entry(entity).State = EntityState.Modified;
            await _cabBookingDbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<T> DeleteAsync(T entity)
        {
            _cabBookingDbContext.Set<T>().Remove(entity);
            await _cabBookingDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> GetOneById(int id)
        {
            return await _cabBookingDbContext.Set<T>().FindAsync(id);
        }
    }
}