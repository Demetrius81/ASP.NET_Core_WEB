using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IClientManager
    {
        Task<Client> GetItemAsync(Guid id);
        Task<IEnumerable<Client>> GetItemsAsync(int skip, int take);
        Task<Guid> AddItemAsync(ClientRequest request);
        Task<bool> DeleteItemAsync(Guid id);
    }
}
