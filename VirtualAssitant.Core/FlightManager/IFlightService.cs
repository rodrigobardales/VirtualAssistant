using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3.Data;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.FlightManager
{
    public interface IFlightService
    {
        Task<OperationResult<Event>> BookFlightAsync(string flightNumber);
        Task<OperationResult<IReadOnlyList<FlightResponse>>> GetFlightsAsync();
        Task<OperationResult<IReadOnlyList<FlightResponse>>> GetByOrigin(string origin);
        Task<OperationResult<IReadOnlyList<FlightResponse>>> GetBySourceAndDestination(string source, string destiny);
        Task<OperationResult<FlightResponse>> GetByFlightNumber(string flightNumber);
    }
}
