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
        Task<OperationResult<Flight2>> AddAsync(Flight2 flight);
        Task<OperationResult<IReadOnlyList<Flight2>>> GetByOrigin(string origin);
        Task<OperationResult<IReadOnlyList<Flight2>>> GetByDestination(string destiny);
        Task<OperationResult<IReadOnlyList<Flight2>>> GetByFlightNumber(string FlightNumber);
    }
}
