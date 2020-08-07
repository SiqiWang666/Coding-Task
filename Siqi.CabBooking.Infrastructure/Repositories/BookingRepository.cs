using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Siqi.CabBooking.Core.Entities;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Infrastructure.Data;

namespace Siqi.CabBooking.Infrastructure.Repositories
{
    public class BookingRepository : EfRepository<Booking>, IBookingRepository
    {
        public BookingRepository(CabBookingDbContext cabBookingDbContext) : base(cabBookingDbContext)
        {
        }

        public override async Task<IEnumerable<Booking>> FilterAllAsync(Expression<Func<Booking, bool>> filter)
        {
            var bookings = await _cabBookingDbContext.Bookings.Where(filter).Include(b => b.FromPlace)
                .Include(b => b.ToPlace).ToListAsync();
            return bookings;
        }
    }
}