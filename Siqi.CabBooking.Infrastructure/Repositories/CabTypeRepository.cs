using Siqi.CabBooking.Core.Entities;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Infrastructure.Data;

namespace Siqi.CabBooking.Infrastructure.Repositories
{
    public class CabTypeRepository: EfRepository<CabType>, ICabTypeRepository
    {
        public CabTypeRepository(CabBookingDbContext cabBookingDbContext) : base(cabBookingDbContext)
        {
        }
    }
}