using System;
using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
	public class CityRoot
	{
        [JsonProperty("results")]
        public List<City> Results { get; set; }

        [JsonProperty("query")]
        public Query Query { get; set; }
    }
}

