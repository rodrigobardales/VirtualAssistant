using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.EventManager
{
    internal interface IMyEventService
    {
        Task<OperationResult<MyEvent>> AddEventAsync(string FlightNumber);
        Task<OperationResult<MyEvent>> DeleteEventAsync(string FlightNumber);
        Task<OperationResult<IReadOnlyList<MyEvent>>> GetAllAsync();
    }
}
