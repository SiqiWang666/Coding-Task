using System.Collections.Generic;
using System.Threading.Tasks;
using Siqi.CabBooking.Core.Models;

namespace Siqi.CabBooking.Core.ServiceInterfaces
{
    public interface IBookingService
    {
        Task<IEnumerable<BookingResponseModel>> GetAllBookingsByCabId(int id);
    }
}