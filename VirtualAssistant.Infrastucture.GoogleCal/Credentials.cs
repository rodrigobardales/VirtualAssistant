using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
var credential = GoogleCredential.FromFile("./googleSecret.json").CreateScoped(CalendarService.Scope.Calendar);
var service = new CalendarService(new BaseClientService.Initializer() { 
    HttpClientInitializer = credential });

var newEvent = new Event()
{
    Summary = "Mi evento",
    Start = new EventDateTime()
    {
        DateTime = DateTime.Now.AddDays(1)
    },
    End = new EventDateTime()
    {
        DateTime = DateTime.Now.AddDays(2)
    }
};

var createdEvent = service.Events.Insert(newEvent, "primary").Execute();