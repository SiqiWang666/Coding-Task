using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Siqi.CabBooking.Core.Models;
using Siqi.CabBooking.Core.ServiceInterfaces;

namespace Siqi.CabBooking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CabController : ControllerBase
    {
        private readonly ICabService _cabService;

        public CabController(ICabService cabService)
        {
            _cabService = cabService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAllCabs()
        {
            var cabs = await _cabService.GetAllCabs();
            return Ok(cabs);
        }
    }
}