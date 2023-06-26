using System;
using VirtualAssitant.Core.Client;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.PlaceManager
{
    public class PlaceService : IPlaceService
	{
		private readonly GeopifyClient _client;

		public PlaceService(GeopifyClient client)
		{
			_client = client;
		}

        public async Task<OperationResult<List<Place>>> GetPlacesByCityAndCategoryAsync(string city, string category)
        {
            var cityInformation = (await _client.GetCityAsync(city)).FirstOrDefault();
            var places = await _client.GetPlacesAsync(cityInformation.PlaceId, category);
            return new OperationResult<List<Place>>(places);
        }
    }
}

