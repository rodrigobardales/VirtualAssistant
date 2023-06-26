using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class Rank
    {
        [JsonProperty("importance")]
        public double Importance { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }

        [JsonProperty("confidence")]
        public int Confidence { get; set; }

        [JsonProperty("confidence_city_level")]
        public int ConfidenceCityLevel { get; set; }

        [JsonProperty("match_type")]
        public string MatchType { get; set; }
    }
}