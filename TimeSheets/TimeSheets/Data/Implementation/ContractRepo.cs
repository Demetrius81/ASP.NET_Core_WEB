using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ContractRepo : IContractRepo
    {
        private readonly TempData _instance;

        public ContractRepo(TempData instance)
        {
            _instance = instance;
        }

        public bool Add(Contract Item)
        {
            throw new NotImplementedException();
        }

        public Contract GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contract> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contract> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Contract item)
        {
            throw new NotImplementedException();
        }
    }
}
