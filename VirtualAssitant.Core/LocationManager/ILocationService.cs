using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.LocationManager
{
    internal interface ILocationService
    {
        Task<OperationResult<Location>> AddAsync(Location location);
        Task<OperationResult<IReadOnlyList<Location>>> GetByCity(string city);
        Task<OperationResult<IReadOnlyList<Location>>> GetByCategory(string category);
    }
}
