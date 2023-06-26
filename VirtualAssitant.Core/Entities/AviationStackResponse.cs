using System;
using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
	public class AviationStackResponse<T>
	{
        [JsonProperty("pagination")]
        public Pagination Pagination { get; set; }

        [JsonProperty("data")]
        public List<T> Data { get; set; }
	}
}

