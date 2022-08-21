using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface IContractRepo : IRepoBase<Contract>
    {
        Task<Contract> GetItemAsyncByName(string title);
        Task<bool?> CheckContractIsActiveAsync(Guid contractId);
    }
}
