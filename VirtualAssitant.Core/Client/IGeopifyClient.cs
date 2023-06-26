using System;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.Client
{
	public interface IGeopifyClient
	{
        Task<List<Place>> GetPlacesAsync(string city, string category);
        Task<List<City>> GetCityAsync(string cityName);
    }
}

