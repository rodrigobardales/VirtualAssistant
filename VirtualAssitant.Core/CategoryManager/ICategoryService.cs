using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.CategoryManager
{
    public interface ICategoryService
    {
        Task<OperationResult<Category>> AddAsync(Category category);
        Task<OperationResult<IReadOnlyList<Category>>> GetAllAsync();
    }
}
