using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualAssitant.Core.Entities;

namespace VirtualAssitant.Core.LocationManager
{
    internal class LocationService : ILocationService
    {
        private readonly IRepository<Location> locationRepository;
        private readonly IRepository<Category> categoryRepository;
        public LocationService(
            IRepository<Location> locationRepository,
            IRepository<Category> categoryRepository0)
        {
            this.locationRepository = locationRepository;
            this.categoryRepository = categoryRepository0;
        }

        public async Task<OperationResult<Location>> AddAsync(Location location)
        {
            if (string.IsNullOrEmpty(location.Name))
            {
                return new OperationResult<Location>(new Error
                {
                    Code = ErrorCode.InternalError,
                    Message = "Name is a required field to add a location"
                });
            }
            if (string.IsNullOrEmpty(location.City))
            {
                return new OperationResult<Location>(new Error
                {
                    Code = ErrorCode.InternalError,
                    Message = "City is a required field to add a location"
                });
            }
            if (string.IsNullOrEmpty(location.Country))
            {
                return new OperationResult<Location>(new Error
                {
                    Code = ErrorCode.InternalError,
                    Message = "Country is a required field to add a location"
                });
            }

            if(location.categoryId.Count <= 0)
            {
                return new OperationResult<Location>(new Error
                {
                    Code = ErrorCode.InternalError,
                    Message = "Category is a required field to add a location"
                });
            }

            var entity = await this.locationRepository.AddAsync(location);
            await this.locationRepository.CommitAsync();
            return new OperationResult<Location>(entity);

        }

        public async Task<OperationResult<IReadOnlyList<Location>>> GetByCategory(int categoryId)
        {
            //esto no esta filtrando
            return (await this.locationRepository.AllAsync()).ToList();
        }

        public async Task<OperationResult<IReadOnlyList<Location>>> GetByCity(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                return (await this.locationRepository.AllAsync()).ToList();
            }
            return this.locationRepository.Filter(x => x.City == city).ToList();
        }
    }
}
