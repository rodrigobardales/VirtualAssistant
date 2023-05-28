using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.EventManager
{
    public class MyEventService : IMyEventService
    {
        Task<OperationResult<MyEvent>> IMyEventService.AddEventAsync(string FlightNumber)
        {
            throw new NotImplementedException();
        }

        Task<OperationResult<MyEvent>> IMyEventService.DeleteEventAsync(string FlightNumber)
        {
            throw new NotImplementedException();
        }

        Task<OperationResult<IReadOnlyList<MyEvent>>> IMyEventService.GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
