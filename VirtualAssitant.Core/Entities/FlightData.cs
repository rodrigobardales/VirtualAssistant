using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class FlightData
    {
        [JsonProperty("airport")]
        public string Airport { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }

        [JsonProperty("terminal")]
        public string Terminal { get; set; }

        [JsonProperty("gate")]
        public string Gate { get; set; }

        [JsonProperty("delay")]
        public object Delay { get; set; }

        [JsonProperty("scheduled")]
        public DateTime Scheduled { get; set; }

        [JsonProperty("estimated")]
        public DateTime Estimated { get; set; }

        [JsonProperty("actual")]
        public object Actual { get; set; }

        [JsonProperty("estimated_runway")]
        public object EstimatedRunway { get; set; }

        [JsonProperty("actual_runway")]
        public object ActualRunway { get; set; }
    }
}