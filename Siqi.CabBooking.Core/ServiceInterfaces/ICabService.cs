using System.Collections.Generic;
using System.Threading.Tasks;
using Siqi.CabBooking.Core.Models;

namespace Siqi.CabBooking.Core.ServiceInterfaces
{
    public interface ICabService
    {
        Task<IEnumerable<CabResponseModel>> GetAllCabs();
    }
}