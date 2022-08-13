using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface IEmployeeManager
    {
        Task<Employee> GetItemAsync(Guid id);        
        Task<IEnumerable<Employee>> GetItemsAsync(int skip, int take);
        Task<Guid> AddItemAsync(EmployeeRequest request);
        Task<bool> UpdateItemAsync(EmployeeRequest request);
        Task<bool> DeleteItemAsync(Guid id);
    }
}
