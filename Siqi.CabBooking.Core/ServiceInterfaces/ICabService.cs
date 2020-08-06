using System.Collections.Generic;
using System.Threading.Tasks;
using Siqi.CabBooking.Core.Entities;
using Siqi.CabBooking.Core.Models;
using Siqi.CabBooking.Core.Models.requests;

namespace Siqi.CabBooking.Core.ServiceInterfaces
{
    public interface ICabService
    {
        Task<IEnumerable<CabResponseModel>> GetAllCabs();
        
    }
}