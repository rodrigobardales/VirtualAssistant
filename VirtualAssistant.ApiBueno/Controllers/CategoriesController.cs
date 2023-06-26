using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using VirtualAssistant.ApiBueno.DataTransferObjects;
using VirtualAssitant.Core.CategoryManager;
using VirtualAssitant.Core.Entities;

namespace VirtualAssistant.ApiBueno.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet(Name ="GetCategorias")]
        public IActionResult GetCategories()
        {
            return Ok(_categoryService.GetAll());
        }
    }
}