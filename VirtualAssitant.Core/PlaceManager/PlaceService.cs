using System;
using VirtualAssitant.Core.Client;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.PlaceManager
{
    public class PlaceService : IPlaceService
	{
		private readonly IGeopifyClient _client;

		public PlaceService(IGeopifyClient client)
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

