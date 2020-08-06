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
    }
}