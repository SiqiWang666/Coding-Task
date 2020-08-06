using System.Threading.Tasks;
using Siqi.CabBooking.Core.Entities;
using Siqi.CabBooking.Core.Models;

namespace Siqi.CabBooking.Core.RepositoryInterfaces
{
    public interface IPlaceRepository : IAsyncRepository<Place>
    {
        Task<PlaceResponseModel> GetPlaceInfo(int start, int end);
    }
}