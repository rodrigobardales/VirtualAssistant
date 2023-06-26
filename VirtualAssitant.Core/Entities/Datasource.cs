using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class Datasource
    {
        [JsonProperty("sourcename")]
        public string Sourcename { get; set; }

        [JsonProperty("attribution")]
        public string Attribution { get; set; }

        [JsonProperty("license")]
        public string License { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}