using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IEmployeeManager
    {
        Task<Employee> GetItem(Guid id);        
        Task<IEnumerable<Employee>> GetItems(int skip, int take);
        Task<Guid> AddItem(EmployeeRequest request);
        Task<bool> UpdateItem(EmployeeRequest request);
        Task<bool> DeleteItem(Guid id);
    }
}
