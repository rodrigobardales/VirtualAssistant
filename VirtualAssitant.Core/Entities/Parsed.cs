using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class Parsed
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("expected_type")]
        public string ExpectedType { get; set; }
    }
}