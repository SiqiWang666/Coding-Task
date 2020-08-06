using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Siqi.CabBooking.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaceController : ControllerBase
    {
        [HttpGet]
        [Route("info")]
        public async Task<IActionResult> GetPlaceName(int id)
        {
            return Ok();
        }
    }
}