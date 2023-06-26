using System;
using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
	public class Pagination
	{
        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
	}
}

