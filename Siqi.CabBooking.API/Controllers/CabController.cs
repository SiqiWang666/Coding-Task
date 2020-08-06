using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Siqi.CabBooking.Core.Models;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Core.ServiceInterfaces;

namespace Siqi.CabBooking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CabController : ControllerBase
    {
        private readonly ICabService _cabService;
        private readonly IBookingService _bookingService;

        public CabController(ICabService cabService, IBookingService bookingService)
        {
            _cabService = cabService;
            _bookingService = bookingService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCabs()
        {
            var cabs = await _cabService.GetAllCabs();
            return Ok(cabs);
        }

        [HttpGet]
        [Route("bookings/{id}")]
        public async Task<IActionResult> GetAllBookingsByCab([FromRoute] int id)
        {
            var bookings = await _bookingService.GetAllBookingsByCabId(id);
            return Ok(bookings);
        }
    }
}