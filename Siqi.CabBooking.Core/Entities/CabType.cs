using System.Collections.Generic;

namespace Siqi.CabBooking.Core.Entities
{
    public class CabType
    {
        public int Id { get; set; }
        public string CabTypeName { get; set; }

        public IEnumerable<Booking> Bookings { get; set; }
    }
}