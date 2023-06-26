using System;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using VirtualAssistant.ApiBueno.DataTransferObjects;
using VirtualAssitant.Core.FlightManager;

namespace VirtualAssistant.ApiBueno.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlaceController : ControllerBase
    {
        [HttpGet(Name = "GetPlaces")]
        public async Task<IActionResult> GetPlaces()
        {
            return Ok();
        }
    }
}

