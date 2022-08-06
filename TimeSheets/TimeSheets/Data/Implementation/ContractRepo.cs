using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ContractRepo : IContractRepo
    {
        public void Add(Contract Item)
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

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Contract item)
        {
            throw new NotImplementedException();
        }
    }
}
