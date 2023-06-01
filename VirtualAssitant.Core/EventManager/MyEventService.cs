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
        private readonly IRepository<MyEvent> myeventrepository;
        
        Task<OperationResult<MyEvent>> IMyEventService.AddEventAsync(MyEvent myevent)
        {
            throw new NotImplementedException();
        }

        async Task<OperationResult<MyEvent>> IMyEventService.DeleteEventAsync(int eventId)
        {
            var existingEvent = await myeventrepository.GetByIdAsync(eventId);

            if (existingEvent == null)
            {
                return new OperationResult<MyEvent>(new Error
                {
                    Code = ErrorCode.NotFound,
                    Message = "Event does not exist"
                });
            }

            try
            {
                await myeventrepository.DeleteAsync(existingEvent);
                await myeventrepository.SaveChangesAsync();

                return new OperationResult<MyEvent>(existingEvent);
            }
            catch (Exception ex)
            {
                return new OperationResult<MyEvent>(new Error
                {
                    Code = ErrorCode.InternalError,
                    Message = "Error occurred while deleting the event",
                    Exception = ex
                });
            }

        }

        async Task<OperationResult<IReadOnlyList<MyEvent>>> IMyEventService.GetAllAsync()
        {
            return (await this.myeventrepository.AllAsync()).ToList();
        }
    }
}
