using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
    public class Timezone
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("offset_STD")]
        public string OffsetSTD { get; set; }

        [JsonProperty("offset_STD_seconds")]
        public int OffsetSTDSeconds { get; set; }

        [JsonProperty("offset_DST")]
        public string OffsetDST { get; set; }

        [JsonProperty("offset_DST_seconds")]
        public int OffsetDSTSeconds { get; set; }

        [JsonProperty("abbreviation_STD")]
        public string AbbreviationSTD { get; set; }

        [JsonProperty("abbreviation_DST")]
        public string AbbreviationDST { get; set; }
    }
}