using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class Codeshared
    {
        [JsonProperty("airline_name")]
        public string AirlineName { get; set; }

        [JsonProperty("airline_iata")]
        public string AirlineIata { get; set; }

        [JsonProperty("airline_icao")]
        public string AirlineIcao { get; set; }

        [JsonProperty("flight_number")]
        public string FlightNumber { get; set; }

        [JsonProperty("flight_iata")]
        public string FlightIata { get; set; }

        [JsonProperty("flight_icao")]
        public string FlightIcao { get; set; }
    }
}