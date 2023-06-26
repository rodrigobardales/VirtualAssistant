using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;
using Newtonsoft.Json;

namespace VirtualAssitant.Core.CategoryManager
{
    public class CategoryService : ICategoryService
    {
        public OperationResult<List<Category>> GetAll()
        {
            string categoriesFileContent = File.ReadAllText("categories.json");
            var categories = JsonConvert.DeserializeObject<List<Category>>(categoriesFileContent);
            return new OperationResult<List<Category>>(categories);
        }
    }
}
