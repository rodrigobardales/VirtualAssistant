using System;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using VirtualAssistant.ApiBueno.DataTransferObjects;
using VirtualAssitant.Core.FlightManager;
using VirtualAssitant.Core.PlaceManager;
using VirtualAssistant.ApiBueno.QueryParameters;

namespace VirtualAssistant.ApiBueno.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlaceController : ControllerBase
    {
        private readonly IPlaceService _placeService;

        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }

        [HttpPost(Name = "GetPlaces")]
        public async Task<IActionResult> GetPlaces(PlaceSearch placeSearch)
        {
            var places = await _placeService.GetPlacesByCityAndCategoryAsync(placeSearch.City, placeSearch.Category);
            return Ok(places);
        }
    }
}

