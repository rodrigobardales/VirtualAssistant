using System;
using Newtonsoft.Json;

namespace VirtualAssitant.Core.Entities
{
	public class City
	{
        [JsonProperty("datasource")]
        public Datasource Datasource { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_code")]
        public string CountryCode { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("city")]
        public string CityName { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("state_code")]
        public string StateCode { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("timezone")]
        public Timezone Timezone { get; set; }

        [JsonProperty("plus_code")]
        public string PlusCode { get; set; }

        [JsonProperty("plus_code_short")]
        public string PlusCodeShort { get; set; }

        [JsonProperty("result_type")]
        public string ResultType { get; set; }

        [JsonProperty("rank")]
        public Rank Rank { get; set; }

        [JsonProperty("place_id")]
        public string PlaceId { get; set; }

        [JsonProperty("bbox")]
        public Bbox Bbox { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("housenumber")]
        public string Housenumber { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("hamlet")]
        public string Hamlet { get; set; }
    }
}

