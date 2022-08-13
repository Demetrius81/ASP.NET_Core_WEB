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

        public async Task<bool> AddAsync(Contract Item)
        {
            if (Item == null)
            {
                return false;
            }

            _instance.contracts.Add(Item);

            return true;
        }

        public async Task<Contract> GetItemAsync(Guid id)
        {
            return _instance.contracts.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Contract> GetItemAsyncByName(string title)
        {
            return _instance.contracts.FirstOrDefault(x => x.Title == title);
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync()
        {
            return _instance.contracts;
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync(int skip, int take)
        {
            if (skip >= _instance.contracts.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.contracts.Count)
            {
                take = _instance.contracts.Count - skip;
            }

            var contracts = GetSomeItems(skip, take);

            return contracts;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Contract? contract = _instance.contracts.FirstOrDefault(x => x.Id == id);

            if (contract is not null)
            {
                _instance.contracts.Remove(contract);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Contract item)
        {
            Contract? contract = _instance.contracts.FirstOrDefault(x => x.Id == item.Id);

            if (contract == null)
            {
                return false;
            }

            _instance.contracts.Remove(contract);

            _instance.contracts.Add(item);

            return true;
        }

        private IEnumerable<Contract> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance.contracts[i];
            }
        }
    }
}
