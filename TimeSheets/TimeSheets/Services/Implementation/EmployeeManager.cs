using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IUserRepo _employeeRepo;

        public EmployeeManager(IUserRepo employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public Guid AddItem(EmployeeRequest request)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public User GetItem(string Name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(EmployeeRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
