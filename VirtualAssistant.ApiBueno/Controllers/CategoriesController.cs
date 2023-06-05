using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VirtualAssistant.ApiBueno.DataTransferObjects;
using VirtualAssitant.Core.Entities;

namespace VirtualAssistant.ApiBueno.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {

        [HttpGet(Name ="GetCategorias")]
        public IEnumerable<CategoriaDto> GetCategories()
        {
            return (IEnumerable<CategoriaDto>)Ok();
        }
    }
}