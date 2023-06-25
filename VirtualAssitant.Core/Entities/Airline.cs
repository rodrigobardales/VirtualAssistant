using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class Airline
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("iata")]
        public string Iata { get; set; }

        [JsonProperty("icao")]
        public string Icao { get; set; }
    }
}