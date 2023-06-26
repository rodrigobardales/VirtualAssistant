using System;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.PlaceManager
{
	public interface IPlaceService
	{
		Task<OperationResult<List<Place>>> GetPlacesByCityAndCategoryAsync(string city, string category);
	}
}

