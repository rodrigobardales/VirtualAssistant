using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;

namespace VirtualAssistant.Infrastucture.GoogleCal
{
    public class GoogleCalendarService
    {
        private readonly CalendarService _calendarService;

        public GoogleCalendarService()
        {
            var credential = GoogleCredential.FromFile("googleSecret.json").CreateScoped(CalendarService.Scope.Calendar);
            _calendarService = new CalendarService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential
            });
        }

        public Event BookEvent(string eventName, DateTime start, DateTime end)
        {
            var newEvent = new Event()
            {
                Summary = eventName,
                Start = new EventDateTime()
                {
                    DateTime = start
                },
                End = new EventDateTime()
                {
                    DateTime = end
                }
            };

            var createdEvent = _calendarService.Events.Insert(newEvent, "primary").Execute();

            return createdEvent;
        }
    }
}


