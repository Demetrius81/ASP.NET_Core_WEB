using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class ContractManager : IContractManager
    {
        private readonly IContractRepo _contractRepo;

        public ContractManager(IContractRepo contractRepo)
        {
            _contractRepo = contractRepo;
        }

        public async Task<Guid> AddItemAsync(ContractRequest request)
        {
            Contract contract = new Contract()
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                DateStart = request.DateStart,
                DateEnd = request.DateEnd,
                Description = request.Description,
                Services = request.Services
            };

            bool flag = await _contractRepo.AddAsync(contract);

            return flag ? contract.Id : default;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            return await _contractRepo.RemoveAsync(id);
        }

        public async Task<Contract> GetItemAsync(Guid id)
        {
            return await _contractRepo.GetItemAsync(id);
        }

        public async Task<Contract> GetItemAsync(string name)
        {
            return await _contractRepo.GetItemAsyncByName(name);
        }

        public async Task<IEnumerable<Contract>> GetItemsAsync(int skip, int take)
        {
            return await _contractRepo.GetItemsAsync(skip, take);
        }

        public async Task<bool> UpdateItemAsync(ContractRequest request)
        {
            Contract contract = await _contractRepo.GetItemAsyncByName(request.Title);

            if (contract == null)
            {
                return false;
            }

            contract = new Contract()
            {
                Id = contract.Id,
                Title = request.Title,
                DateStart = request.DateStart,
                DateEnd = request.DateEnd,
                Description = request.Description,
                Services = request.Services
            };

            bool flag = await _contractRepo.UpdateAsync(contract);

            return flag;
        }
    }
}
