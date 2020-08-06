using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Siqi.CabBooking.Core.Models;
using Siqi.CabBooking.Core.RepositoryInterfaces;
using Siqi.CabBooking.Core.ServiceInterfaces;

namespace Siqi.CabBooking.Infrastructure.Services
{
    public class CabService : ICabService
    {
        private readonly ICabTypeRepository _cabTypeRepository;

        public CabService(ICabTypeRepository cabTypeRepository)
        {
            _cabTypeRepository = cabTypeRepository;
        }

        public async Task<IEnumerable<CabResponseModel>> GetAllCabs()
        {
            var cabs = await _cabTypeRepository.ListAllAsync();
            var response = cabs.Select(c => new CabResponseModel {Id = c.Id, Name = c.CabTypeName});
            return response;
        }
    }
}