using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3.Data;
using VirtualAssistant.Infrastucture.GoogleCal;
using VirtualAssitant.Core.Client;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.FlightManager
{
    public class FlightService : IFlightService
    {
        private readonly AviationStackClient _client;

        private readonly GoogleCalendarService _calendarService;

        public FlightService(AviationStackClient client, GoogleCalendarService calendarService)
        {
            _client = client;
            _calendarService = calendarService;
        }

        public async Task<OperationResult<Event>> BookFlightAsync(string flightNumber)
        {
            var flight = (await _client.GetFlightsAsync()).Data.Where(flight => flight.Flight.Number == flightNumber).FirstOrDefault();
            var result = _calendarService.BookEvent($"Vuelo {flightNumber}", flight.Departure.Scheduled, flight.Arrival.Scheduled);
            return new OperationResult<Event>(result);
        }

        public async Task<OperationResult<IReadOnlyList<FlightResponse>>> GetFlightsAsync()
        {
            var flights = await _client.GetFlightsAsync();
            return new OperationResult<IReadOnlyList<FlightResponse>>(flights.Data);
        }

        public async Task<OperationResult<IReadOnlyList<FlightResponse>>> GetBySourceAndDestination(string source, string destiny)
        {
            var flights = await _client.GetFlightsAsync();
            var filteredFlights = flights.Data.Where(flight => flight.Departure.Airport == source && flight.Arrival.Airport == destiny).ToList();
            return new OperationResult<IReadOnlyList<FlightResponse>>(filteredFlights);
        }

        public async Task<OperationResult<FlightResponse>> GetByFlightNumber(string flightNumber)
        {
            var flight = (await _client.GetFlightsAsync()).Data.Where(flight => flight.Flight.Number == flightNumber).FirstOrDefault();
            return new OperationResult<FlightResponse>(flight);
        }

        public async Task<OperationResult<IReadOnlyList<FlightResponse>>> GetByOrigin(string origin)
        {
            var flights = await _client.GetFlightsAsync();
            var filteredFlights = flights.Data.Where(flight => flight.Departure.Airport == origin).ToList();
            return new OperationResult<IReadOnlyList<FlightResponse>>(filteredFlights);
        }
    }
}
