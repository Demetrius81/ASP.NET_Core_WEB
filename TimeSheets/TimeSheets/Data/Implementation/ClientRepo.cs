using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ClientRepo : IClientRepo
    {
        private readonly TempData _instance;

        public ClientRepo(TempData instance)
        {
            _instance = instance;
        }

        public bool Add(Client Item)
        {
            throw new NotImplementedException();
        }

        public Client GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Client item)
        {
            throw new NotImplementedException();
        }
    }
}
