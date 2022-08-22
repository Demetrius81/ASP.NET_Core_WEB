using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class ContractRepo : IContractRepo
    {
        private readonly TimeSheetDbContext _instance;

        public ContractRepo(TimeSheetDbContext instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Contract Item)
        {
            if (Item == null)
            {
                return false;
            }

            await _instance.Contracts.AddAsync(Item);

            return true;
        }

        public async Task<bool?> CheckContractIsActiveAsync(Guid contractId)
        {
            Contract? contract = await _instance.Contracts.FindAsync(contractId);

            DateTime dateNow = DateTime.Now;

            bool? isActive = dateNow <= contract?.DateEnd && dateNow >= contract?.DateStart;

            return isActive;
        }

        public async Task<Contract> GetItemAsync(Guid id)
        {
            return _instance.Contracts.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Contract> GetItemAsyncByName(string title)
        {
            return _instance.Contracts.FirstOrDefault(x => x.Title == title);
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync()
        {
            return _instance.Contracts;
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync(int skip, int take)
        {
            int count = _instance.Contracts.Count();

            if (skip >= count)
            {
                return null;
            }

            if ((skip + take) > count)
            {
                take = count - skip;
            }

            var contracts = _instance.Contracts.Skip(skip).Take(take).ToList();

            return contracts;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Contract? contract = _instance.Contracts.FirstOrDefault(x => x.Id == id);

            if (contract is not null)
            {
                _instance.Contracts.Remove(contract);

                await _instance.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Contract item)
        {
            Contract? contract = _instance.Contracts.FirstOrDefault(x => x.Id == item.Id);

            if (contract == null)
            {
                return false;
            }

            _instance.Contracts.Update(contract);

            await _instance.SaveChangesAsync();

            return true;
        }
    }
}
