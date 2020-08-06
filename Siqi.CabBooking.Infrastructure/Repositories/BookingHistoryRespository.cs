using Siqi.CabBooking.Core.Entities;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Infrastructure.Data;

namespace Siqi.CabBooking.Infrastructure.Repositories
{
    public class BookingHistoryRespository : EfRepository<BookingHistory>, IBookingHistoryRepository
    {
        public BookingHistoryRespository(CabBookingDbContext cabBookingDbContext) : base(cabBookingDbContext)
        {
        }
    }
}