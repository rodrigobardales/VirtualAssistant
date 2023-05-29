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
            throw new NotImplementedException();
        }

        public Task<OperationResult<IReadOnlyList<Category>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
