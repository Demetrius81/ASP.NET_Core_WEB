using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ClientRepo : IClientRepo
    {
        private readonly TimeSheetDbContext _instance;

        public ClientRepo(TimeSheetDbContext instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Client Item)
        {
            if (Item == null)
            {
                return false;
            }

            await _instance.Clients.AddAsync(Item);

            await _instance.SaveChangesAsync();

            return true;
        }

        public async Task<Client> GetItemAsync(Guid id)
        {
            return _instance.Clients.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<Client>> GetItemsAsync()
        {
            return _instance.Clients;
        }

        public async Task<IEnumerable<Client>> GetItemsAsync(int skip, int take)
        {
            int count = _instance.Clients.Count();

            if (skip >= count)
            {
                return null;
            }

            if ((skip + take) > count)
            {
                take = count;
            }

            var clients = _instance.Clients.Skip(skip).Take(take).ToList();

            return clients;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Client? client = _instance.Clients.FirstOrDefault(x => x.Id == id);

            if (client is not null)
            {
                _instance.Clients.Remove(client);

                await _instance.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Client item)
        {
            Client? client = _instance.Clients.FirstOrDefault(x => x.Id == item.Id);

            if (client == null)
            {
                return false;
            }

            _instance.Clients.Update(client);

            await _instance.SaveChangesAsync();

            return true;
        }        
    }
}
