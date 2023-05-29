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
        public Task<OperationResult<Flight>> AddAsync(Flight flight)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Flight>>> GetByDestination(string destiny)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Flight>>> GetByFlightNumber(string FlightNumber)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Flight>>> GetByOrigin(string origin)
        {
            throw new NotImplementedException();
        }
    }
}
