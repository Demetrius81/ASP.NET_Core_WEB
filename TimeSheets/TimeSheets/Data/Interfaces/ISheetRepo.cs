using TimeSheets.Models;

namespace TimeSheets.Data.Interfaces
{
    public interface ISheetRepo : IRepoBase<Sheet>
    {
        Task<Sheet> GetItemAsyncByDate(DateTime date);
    }
}
