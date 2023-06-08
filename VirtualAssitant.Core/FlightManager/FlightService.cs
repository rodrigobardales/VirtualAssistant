using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.FlightManager
{
    public class FlightService : IFlightService
    {
        public Task<OperationResult<Flight2>> AddAsync(Flight2 flight)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Flight2>>> GetByDestination(string destiny)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Flight2>>> GetByFlightNumber(string FlightNumber)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Flight2>>> GetByOrigin(string origin)
        {
            throw new NotImplementedException();
        }
    }
}
