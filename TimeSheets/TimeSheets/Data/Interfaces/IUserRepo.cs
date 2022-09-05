using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface IUserRepo : IRepoBase<User>
    {
        Task<User> GetItemByNameAsync(string name);
        Task<User> GetItemByLoginAndPasswordHashAsync(string login, byte[] passwordHash);
    }
}
