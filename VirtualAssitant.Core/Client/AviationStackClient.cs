using System;
using Newtonsoft.Json;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.Client
{
	public class AviationStackClient : IDisposable
	{
        private readonly HttpClient _client;

        private readonly string _url;

        private readonly string _accessKey;

        public AviationStackClient()
        {
            _client = new HttpClient();
            _url = "http://api.aviationstack.com/v1";
            _accessKey = "1ff6da4ddadcab21f03cc4f5d0af2947";
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

        public async Task<AviationStackResponse<FlightResponse>> GetFlightsAsync()
        {
            var response = await _client.GetAsync($"{_url}/flights?access_key={_accessKey}");
            var responseContent = await response.Content.ReadAsStringAsync();
            AviationStackResponse<FlightResponse> flights = JsonConvert.DeserializeObject<AviationStackResponse<FlightResponse>>(responseContent);
            return flights;
        }
    }
}

