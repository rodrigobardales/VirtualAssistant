using System;
using Microsoft.AspNetCore.Mvc;
using VirtualAssitant.Core.FlightManager;
using VirtualAssitant.Core.Entities;
using VirtualAssitant.Core;
using System.ComponentModel.DataAnnotations;
using VirtualAssistant.ApiBueno.QueryParameters;
using VirtualAssistant.ApiBueno.DataTransferObjects;

namespace VirtualAssistant.ApiBueno.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet(Name = "GetFlights")]
        public async Task<IActionResult> GetFlights()
        {
            return Ok(await _flightService.GetFlightsAsync());
        }

        /// <summary>
        /// Gets a flight by origin, destination and date
        /// </summary>
        /// <param name="source">Airport source</param>
        /// <param name="destination">Airport destination</param>
        /// <param name="date">Flight date (yyyy-MM-dd)</param>
        /// <returns>A list of flights with given parameters</returns>
        /// <response code="200">Returns list of flights</response>
        // GET: api/<BlogController>/5
        [HttpGet]
        [Route("source/{source}/destination/{destination}/date/{date}")]
        public async Task<IActionResult> GetFlightsByOriginAndDestination(string source, string destination, string date)
        {
            return Ok(await _flightService.GetBySourceAndDestination(source, destination));
        }
        

        [HttpGet("{flightNumber}", Name = "GetFlight")]
        public async Task<IActionResult> GetFlight(string flightNumber)
        {
            return Ok(await _flightService.GetByFlightNumber(flightNumber));
        }

        [HttpPost]
        public async Task<IActionResult> BookFlight([FromBody]FlightBookingDto flightBooking)
        {
            return Ok(await _flightService.BookFlightAsync(flightBooking.FlightNumber));
        }
    }
}

