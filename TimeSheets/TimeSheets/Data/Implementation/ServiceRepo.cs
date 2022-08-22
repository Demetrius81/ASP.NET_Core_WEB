using Newtonsoft.Json;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ServiceRepo : IServiceRepo
    {
        private readonly TimeSheetDbContext _instance;

        public ServiceRepo(TimeSheetDbContext instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Service Item)
        {
            if (Item == null)
            {
                return false;
            }

            await _instance.Services.AddAsync(Item);

            await _instance.SaveChangesAsync();

            return true;
        }

        public async Task<Service> GetItemAsync(Guid id)
        {
            return _instance.Services.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Service> GetItemAsyncByName(string name)
        {
            return _instance.Services.FirstOrDefault(x => x.Name == name);
        }

        public async Task<IEnumerable<Service>> GetItemsAsync()
        {
            return _instance.Services;
        }

        public async Task<IEnumerable<Service>> GetItemsAsync(int skip, int take)
        {
            int count = _instance.Services.Count();

            if (skip >= count)
            {
                return null;
            }

            if ((skip + take) > count)
            {
                take = count - skip;
            }

            List<Service> services = _instance.Services.Skip(skip).Take(take).ToList();

            return services;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Service? service = _instance.Services.FirstOrDefault(x => x.Id == id);

            if (service is not null)
            {
                _instance.Services.Remove(service);

                await _instance.SaveChangesAsync(true);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Service item)
        {
            Service? service = _instance.Services.FirstOrDefault(x => x.Id == item.Id);

            if (service == null)
            {
                return false;
            }

            _instance.Services.Update(service);

            await _instance.SaveChangesAsync(true);

            return true;
        }
    }
}
