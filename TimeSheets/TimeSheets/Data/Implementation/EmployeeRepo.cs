using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly TimeSheetDbContext _instance;

        public EmployeeRepo(TimeSheetDbContext instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Employee Item)
        {
            if (Item == null)
            {
                return false;
            }

            await _instance.Employees.AddAsync(Item);

            await _instance.SaveChangesAsync();

            return true;
        }

        public async Task<Employee> GetItemAsync(Guid id)
        {
            return _instance.Employees.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Employee> GetItemByUserIdAsync(Guid userId)
        {
            return _instance.Employees.FirstOrDefault(x => x.UserId == userId);
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync()
        {
            return _instance.Employees;
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync(int skip, int take)
        {
            int count = _instance.Users.Count();

            if (skip >= count)
            {
                return null;
            }

            if ((skip + take) > count)
            {
                take = count - skip;
            }

            var employees = _instance.Employees.Skip(skip).Take(take).ToList();

            return employees;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Employee? employee = _instance.Employees.FirstOrDefault(x => x.Id == id);

            if (employee is not null)
            {
                _instance.Employees.Remove(employee);

                await _instance.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Employee item)
        {
            Employee? employee = _instance.Employees.FirstOrDefault(x => x.Id == item.Id);

            if (employee == null)
            {
                return false;
            }

            _instance.Employees.Update(employee);

            await _instance.SaveChangesAsync();

            return true;
        }
    }
}
