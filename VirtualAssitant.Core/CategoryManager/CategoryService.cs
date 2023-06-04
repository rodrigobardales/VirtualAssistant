using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.CategoryManager
{
    public class CategoryService : ICategoryService
    {
        public Task<OperationResult<Category>> AddAsync(Category category)
        {
            Category category1 = new Category();
            category1.CategoryName = category.CategoryName;
            return Task.FromResult(new OperationResult<Category>(category1));
        }

        public Task<OperationResult<IReadOnlyList<Category>>> GetAllAsync()
        {
            Category category1 = new Category();
            category1.CategoryName = "Category1";
            return Task.FromResult(new OperationResult<IReadOnlyList<Category>>(new List<Category>() 
            { 
                category1 
            }));
        }
    }
}
