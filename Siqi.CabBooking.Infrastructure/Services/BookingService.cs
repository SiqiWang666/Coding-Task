using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Siqi.CabBooking.Core.Models;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Core.ServiceInterfaces;

namespace Siqi.CabBooking.Infrastructure.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IPlaceRepository _placeRepository;

        public BookingService(IPlaceRepository placeRepository, IBookingRepository bookingRepository)
        {
            _placeRepository = placeRepository;
            _bookingRepository = bookingRepository;
        }

        public async Task<IEnumerable<BookingResponseModel>> GetAllBookingsByCabId(int id)
        {
            var collections = await _bookingRepository.FilterAllAsync(b => b.CabTypeId == id);
            var bookings = collections.Select(b => new BookingResponseModel
            {
                Id = b.Id,
                Email = b.Email,
                BookingDate = b.BookingDate,
                BookingTime = b.BookingTime,
                FromPlaceId = b.FromPlaceId,
                ToPlaceId = b.ToPlaceId,
                PickupAddress = b.PickupAddress,
                Landmark = b.Landmark,
                PickupDate = b.PickupDate,
                PickupTime = b.PickupTime,
                ContactNo = b.ContactNo,
                Status = b.Status
            }).ToList();
            foreach (var booking in bookings)
            {
                var start = await _placeRepository.GetOneById(booking.FromPlaceId);
                var end = await _placeRepository.GetOneById(booking.ToPlaceId);
                booking.StartPlace = start.PlaceName;
                booking.ToPlace = end.PlaceName;
            }
            return bookings;
        }
    }
}