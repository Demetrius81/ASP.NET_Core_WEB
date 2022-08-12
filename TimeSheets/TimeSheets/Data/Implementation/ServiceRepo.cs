using Newtonsoft.Json;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ServiceRepo : IServiceRepo
    {
        private readonly TempData _instance;

        public ServiceRepo(TempData instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Service Item)
        {
            if (Item == null)
            {
                return false;
            }

            _instance.services.Add(Item);

            return true;
        }

        public async Task<Service> GetItemAsync(Guid id)
        {
            return _instance.services.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<Service>> GetItemsAsync()
        {
            return _instance.services;
        }

        public async Task<IEnumerable<Service>> GetItemsAsync(int skip, int take)
        {
            if (skip >= _instance.services.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.services.Count)
            {
                take = _instance.services.Count - skip;
            }

            var services = GetSomeItems(skip, take);

            return services;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Service? service = _instance.services.FirstOrDefault(x => x.Id == id);

            if (service is not null)
            {
                _instance.services.Remove(service);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Service item)
        {
            Service? service = _instance.services.FirstOrDefault(x => x.Id == item.Id);

            if (service == null)
            {
                return false;
            }

            _instance.services.Remove(service);

            _instance.services.Add(item);

            return true;
        }

        private IEnumerable<Service> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance.services[i];
            }
        }
    }
}
