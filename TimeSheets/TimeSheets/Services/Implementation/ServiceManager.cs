using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class ServiceManager : ISerrviceManager
    {
        private readonly IServiceRepo _serviceRepo;

        public ServiceManager(IServiceRepo serviceRepo)
        {
            _serviceRepo = serviceRepo;
        }

        public async Task<Guid> AddItemAsync(ServiceRequest request)
        {
            Service service = new Service()
            {
                Id = Guid.NewGuid(),
                Name = request.Name
            };

            bool flag = await _serviceRepo.AddAsync(service);

            return flag ? service.Id : default;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            return await _serviceRepo.RemoveAsync(id);
        }

        public async Task<Service> GetItemAsync(Guid id)
        {
            return await _serviceRepo.GetItemAsync(id);
        }

        public async Task<Service> GetItemAsync(string name)
        {
            return await _serviceRepo.GetItemAsyncByName(name);
        }

        public async Task<IEnumerable<Service>> GetItemsAsync(int skip, int take)
        {
            return await _serviceRepo.GetItemsAsync(skip, take);
        }

        public async Task<bool> UpdateItemAsync(ServiceRequest request)
        {
            Service service = await _serviceRepo.GetItemAsyncByName(request.Name);

            if (service == null)
            {
                return false;
            }

            service = new Service()
            {
                Id = service.Id,
                Name = request.Name
            };

            bool flag = await _serviceRepo.UpdateAsync(service);

            return flag;
        }
    }
}
