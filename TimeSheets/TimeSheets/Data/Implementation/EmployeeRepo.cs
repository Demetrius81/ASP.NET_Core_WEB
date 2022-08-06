using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private static List<Employee> _instance = new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.Parse("ADA3AF64-60A4-D449-6D62-79A3CDD3BD21"),
                UserId = Guid.Parse("5824A045-0AEC-F785-D21D-71ABE298F4A9")
            },
            new Employee()
            {
                Id = Guid.Parse("2552FEFD-2265-6871-89A2-AEC27902ED3A"),
                UserId = Guid.Parse("10197B7E-C6B9-960A-E7F3-731577591016")
            },
            new Employee()
            {
                Id = Guid.Parse("9C279E82-5E55-736A-893D-79A1C644169C"),
                UserId = Guid.Parse("B9E27F57-B214-1DBA-B51B-BB9ADB03C338")
            },
            new Employee()
            {
                Id = Guid.Parse("D16B655D-F3F0-9C0A-834E-11D29632F943"),
                UserId = Guid.Parse("BB6A545E-1902-73A6-FCA5-1B82A71683A9")
            },
            new Employee()
            {
                Id = Guid.Parse("36DCD7A0-D9DF-8144-8656-C1E1839AEC83"),
                UserId = Guid.Parse("C655B78C-45B0-3433-D38A-42A6918DB8E4")
            }
        };

        public void Add(Employee Item)
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

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Employee item)
        {
            throw new NotImplementedException();
        }
    }
}
