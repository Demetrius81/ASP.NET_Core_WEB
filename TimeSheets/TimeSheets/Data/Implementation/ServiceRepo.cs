using Newtonsoft.Json;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ServiceRepo : IServiceRepo
    {
        private readonly TempData _instance;

        public ServiceRepo(TempData instance)
        {
            _instance = instance;
        }

        public bool Add(Service Item)
        {
            throw new NotImplementedException();
        }

        public Service GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Service> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Service item)
        {
            throw new NotImplementedException();
        }
    }
}
