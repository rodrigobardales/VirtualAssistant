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
        Task<OperationResult<MyEvent>> AddEventAsync(MyEvent myevent);
        Task<OperationResult<MyEvent>> DeleteEventAsync(int eventId);
        Task<OperationResult<IReadOnlyList<MyEvent>>> GetAllAsync();
    }
}
