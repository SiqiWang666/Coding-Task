using System.Threading.Tasks;
using Siqi.CabBooking.Core.Entities;
using Siqi.CabBooking.Core.Models;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Infrastructure.Data;

namespace Siqi.CabBooking.Infrastructure.Repositories
{
    public class PlaceRepository: EfRepository<Place>, IPlaceRepository
    {
        public PlaceRepository(CabBookingDbContext cabBookingDbContext) : base(cabBookingDbContext)
        {
        }

        public async Task<PlaceResponseModel> GetPlaceInfo(int start, int end)
        {
            var startPlace = await GetOneById(start);
            var destination = await GetOneById(end);
            return new PlaceResponseModel{Start = startPlace.PlaceName, Destination = destination.PlaceName};
        }
    }
}