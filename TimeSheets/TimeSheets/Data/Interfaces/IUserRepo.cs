using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface IUserRepo : IRepoBase<User>
    {
        Task<User> GetItemAsyncByName(string name);
    }
}
