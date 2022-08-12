using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface IEmployeeRepo : IRepoBase<Employee>
    {
        Task<Employee> GetItemByUserIdAsync(Guid userId);
    }
}
