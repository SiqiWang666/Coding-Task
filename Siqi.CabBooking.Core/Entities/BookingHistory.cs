using System;

namespace Siqi.CabBooking.Core.Entities
{
    public class BookingHistory
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime? BookingDate { get; set; }
        public DateTime? BookingTime { get; set; }
        public int? FromPlaceId { get; set; }
        public int? ToPlaceId { get; set; }
        public string PickupAddress { get; set; }
        public string Landmark { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? PickupTime { get; set; }
        public int? CabTypeId { get; set; }
        public string ContactNo { get; set; }
        public string Status { get; set; }
        public string CompTime { get; set; }
        public Decimal? Charge { get; set; }
        public string Feedback { get; set; }
    }
}