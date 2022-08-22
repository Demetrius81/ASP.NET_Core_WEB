using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface IUserRepo : IRepoBase<User>
    {
        Task<User> GetItemByNameAsync(string name);
        Task<User> GetItemByLoginAndPasswordAsync(string login, byte[] passwordHash);
    }
}
