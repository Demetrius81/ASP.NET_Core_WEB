using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly TempData _instance;

        public EmployeeRepo(TempData instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Employee Item)
        {
            if (Item == null)
            {
                return false;
            }

            _instance.employes.Add(Item);

            return true;
        }

        public async Task<Employee> GetItemAsync(Guid id)
        {
            return _instance.employes.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Employee> GetItemByUserIdAsync(Guid userId)
        {
            return _instance.employes.FirstOrDefault(x => x.UserId == userId);
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync()
        {
            return _instance.employes;
        }

        public async Task<IEnumerable<Employee>> GetItemsAsync(int skip, int take)
        {
            if (skip >= _instance.employes.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.employes.Count)
            {
                take = _instance.employes.Count - skip;
            }

            var employees = GetSomeItems(skip, take);

            return employees;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Employee? employee = _instance.employes.FirstOrDefault(x => x.Id == id);

            if (employee is not null)
            {
                _instance.employes.Remove(employee);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Employee item)
        {
            Employee? employee = _instance.employes.FirstOrDefault(x => x.Id == item.Id);

            if (employee == null)
            {
                return false;
            }

            _instance.employes.Remove(employee);

            _instance.employes.Add(item);

            return true;
        }

        private IEnumerable<Employee> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance.employes[i];
            }
        }
    }
}
