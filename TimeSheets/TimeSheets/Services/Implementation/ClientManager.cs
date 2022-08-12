using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class ClientManager : IClientManager
    {
        private readonly IClientRepo _clientRepo;

        public ClientManager(IClientRepo clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public async Task<Guid> AddItemAsync(ClientRequest request)
        {
            Client client = new Client()
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId
            };

            bool flag = await _clientRepo.AddAsync(client);

            return flag ? client.Id : default;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            return await _clientRepo.RemoveAsync(id);
        }

        public async Task<Client> GetItemAsync(Guid id)
        {
            return await _clientRepo.GetItemAsync(id);
        }

        public async Task<IEnumerable<Client>> GetItemsAsync(int skip, int take)
        {
            return await _clientRepo.GetItemsAsync(skip, take);
        }
    }
}
