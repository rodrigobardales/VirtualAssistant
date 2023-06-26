using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.Client
{
    public class GeopifyClient : IDisposable
    {
        private readonly HttpClient _client;

        private readonly string _url;

        private readonly string _apiKey;

        public GeopifyClient()
        {
            _client = new HttpClient();
            _url = "https://api.geoapify.com";
            _apiKey = "7c27af9c97a245a39234656019aa27ed";
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _client.Dispose();
            }
        }

        public async Task<List<City>> GetCityAsync(string cityName)
        {
            var response = await _client.GetAsync($"{_url}/v1/geocode/search?text={cityName}&format=json&apiKey={_apiKey}");
            var responseContent = await response.Content.ReadAsStringAsync();
            CityRoot cityResponse = JsonConvert.DeserializeObject<CityRoot>(responseContent);
            return cityResponse.Results;
        }

        public async Task<List<Place>> GetPlacesAsync(string city, string category)
        {
            var response = await _client.GetAsync($"{_url}/v2/places?categories={category}&filter=place:{city}&apiKey={_apiKey}");
            var responseContent = await response.Content.ReadAsStringAsync();
            JObject placesJson = JObject.Parse(responseContent);

            var places = (JArray)placesJson.GetValue("features");
            return places.Select(place => new Place
            {
                 Name = place["properties"]["name"].ToObject<string>(),
                 Street = place["properties"]["street"].ToObject<string>(),
                 AddressLine1 = place["properties"]["address_line1"].ToObject<string>(),
                 AddressLine2 = place["properties"]["address_line2"].ToObject<string>()
            }).ToList();
        }
    }
}

