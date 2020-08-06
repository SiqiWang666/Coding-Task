using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<CabType> GetOneById(int id)
        {
            var cab = await _cabBookingDbContext.CabTypes.Where(c => c.Id == id).Include(c => c.Bookings).FirstOrDefaultAsync();
            return cab;
        }
    }
}