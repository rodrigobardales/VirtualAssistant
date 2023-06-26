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
        OperationResult<List<Category>> GetAll();
    }
}
