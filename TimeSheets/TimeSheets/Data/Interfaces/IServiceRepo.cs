using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface IServiceRepo : IRepoBase<Service>
    {
        Task<Service> GetItemAsyncByName(string name);
    }
}
