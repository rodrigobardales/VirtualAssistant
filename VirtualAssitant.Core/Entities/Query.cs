using System;
using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
	public class Query
	{
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("parsed")]
        public Parsed Parsed { get; set; }
    }
}

