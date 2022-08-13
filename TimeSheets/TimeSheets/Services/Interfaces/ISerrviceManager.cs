using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface ISerrviceManager
    {
        Task<Service> GetItemAsync(Guid id);
        Task<Service> GetItemAsync(string Name);
        Task<IEnumerable<Service>> GetItemsAsync(int skip, int take);
        Task<Guid> AddItemAsync(ServiceRequest request);
        Task<bool> UpdateItemAsync(ServiceRequest request);
        Task<bool> DeleteItemAsync(Guid id);
    }
}
