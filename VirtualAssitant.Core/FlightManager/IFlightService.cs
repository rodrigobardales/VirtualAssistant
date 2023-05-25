using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.FlightManager
{
    public interface IFlightService
    {
        Task<OperationResult<Flight>> AddAsync(Flight flight);
        Task<OperationResult<IReadOnlyList<Flight>>> GetByOrigin(string origin);
        Task<OperationResult<IReadOnlyList<Flight>>> GetByDestination(string destiny);
        Task<OperationResult<IReadOnlyList<Flight>>> GetByFlightNumber(string FlightNumber);
    }
}
