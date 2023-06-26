using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAssitant.Core.Entities
{
    public class FlightResponse
    {
        [JsonProperty("flight_date")]
        public string FlightDate { get; set; }

        [JsonProperty("flight_status")]
        public string FlightStatus { get; set; }

        [JsonProperty("departure")]
        public FlightData Departure { get; set; }

        [JsonProperty("arrival")]
        public FlightData Arrival { get; set; }

        [JsonProperty("airline")]
        public Airline Airline { get; set; }

        [JsonProperty("flight")]
        public Flight Flight { get; set; }

        [JsonProperty("aircraft")]
        public object Aircraft { get; set; }

        [JsonProperty("live")]
        public object Live { get; set; }
    }
}
