using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IUserManager
    {
        User GetItem(Guid id);
        User GetItem(string Name);
        IEnumerable<User> GetItems(int skip, int take);
        Guid AddItem(UserRequest request);
        void UpdateItem(UserRequest request);
        void DeleteItem(Guid id);
    }
}
