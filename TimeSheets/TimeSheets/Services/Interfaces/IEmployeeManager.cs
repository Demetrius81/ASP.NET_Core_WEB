using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IEmployeeManager
    {
        User GetItem(Guid id);
        User GetItem(string Name);
        IEnumerable<User> GetItems(int skip, int take);
        Guid AddItem(EmployeeRequest request);
        bool UpdateItem(EmployeeRequest request);
        bool DeleteItem(Guid id);
    }
}
