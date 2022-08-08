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

        public bool Add(Employee Item)
        {
            throw new NotImplementedException();
        }

        public Employee GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
