using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.LocationManager
{
    internal class LocationService : ILocationService
    {
        public Task<OperationResult<Location>> AddAsync(Location location)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Location>>> GetByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Location>>> GetByCity(string city)
        {
            throw new NotImplementedException();
        }
    }
}
