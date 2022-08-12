using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ClientRepo : IClientRepo
    {
        private readonly TempData _instance;

        public ClientRepo(TempData instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Client Item)
        {
            if (Item == null)
            {
                return false;
            }

            _instance.clients.Add(Item);

            return true;
        }

        public async Task<Client> GetItemAsync(Guid id)
        {
            return _instance.clients.FirstOrDefault(x => x.Id == id);
        }

        public async Task<IEnumerable<Client>> GetItemsAsync()
        {
            return _instance.clients;
        }

        public async Task<IEnumerable<Client>> GetItemsAsync(int skip, int take)
        {
            if (skip >= _instance.clients.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.clients.Count)
            {
                take = _instance.clients.Count - skip;
            }

            var clients = GetSomeItems(skip, take);

            return clients;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Client? client = _instance.clients.FirstOrDefault(x => x.Id == id);

            if (client is not null)
            {
                _instance.clients.Remove(client);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Client item)
        {
            Client? client = _instance.clients.FirstOrDefault(x => x.Id == item.Id);

            if (client == null)
            {
                return false;
            }

            _instance.clients.Remove(client);

            _instance.clients.Add(item);

            return true;
        }

        private IEnumerable<Client> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance.clients[i];
            }
        }
    }
}
