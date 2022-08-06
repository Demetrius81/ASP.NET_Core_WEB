using TimeSheets.Models;

namespace TimeSheets.Services.Interfaces
{
    public interface ISheetManager
    {
        Sheet GetItem(Guid id);
    }
}
