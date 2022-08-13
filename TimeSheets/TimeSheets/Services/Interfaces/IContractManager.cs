

using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IContractManager
    {
        Task<Contract> GetItemAsync(Guid id);
        Task<Contract> GetItemAsync(string name);
        Task<IEnumerable<Contract>> GetItemsAsync(int skip, int take);
        Task<Guid> AddItemAsync(ContractRequest request);
        Task<bool> UpdateItemAsync(ContractRequest request);
        Task<bool> DeleteItemAsync(Guid id);
    }
}
