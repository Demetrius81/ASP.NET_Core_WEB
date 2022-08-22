using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IUserManager
    {
        Task<User> GetItemAsync(Guid id);
        Task<User> GetItemAsync(string Name);
        Task<IEnumerable<User>> GetItemsAsync(int skip, int take);
        Task<Guid> AddItemAsync(UserRequest request);
        Task<bool> UpdateItemAsync(UserRequest request);
        Task<bool> DeleteItemAsync(Guid id);
    }
}
