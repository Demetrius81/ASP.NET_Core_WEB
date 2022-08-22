using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface ISheetManager
    {
        Task<Sheet> GetItemAsync(Guid id);
        Task<Sheet> GetItemAsync(DateTime date);
        Task<IEnumerable<Sheet>> GetItemsAsync(int skip, int take);
        Task<Guid> AddItemAsync(SheetRequest request);
        Task<bool> UpdateItemAsync(SheetRequest request);
        Task<bool> DeleteItemAsync(Guid id);
    }
}
