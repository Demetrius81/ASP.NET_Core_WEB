using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeManager(IEmployeeRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<Guid> AddItemAsync(EmployeeRequest request)
        {
            Employee employee = new Employee()
            {
                Id = Guid.NewGuid(),
                UserId = request.UserId
            };

            bool flag = await _employeeRepo.AddAsync(employee);

            return flag ? employee.Id : default;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            return await _employeeRepo.RemoveAsync(id);
        }

        public async Task<Employee> GetItemAsync(Guid id)
        {
            return await _employeeRepo.GetItemAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync(int skip, int take)
        {
            return await _employeeRepo.GetItemsAsync(skip, take);

        }

        public async Task<bool> UpdateItemAsync(EmployeeRequest request)
        {
            Employee employee = await _employeeRepo.GetItemByUserIdAsync(request.UserId);

            if (employee == null)
            {
                return false;
            }

            employee = new Employee()
            {
                Id = employee.Id,
                UserId = request.UserId
            };

            return await _employeeRepo.UpdateAsync(employee);
        }
    }
}
