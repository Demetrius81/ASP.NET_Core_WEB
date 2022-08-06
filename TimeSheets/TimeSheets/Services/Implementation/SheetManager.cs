using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class SheetManager : ISheetManager
    {
        private readonly ISheetRepo _sheetRepo;

        public SheetManager(ISheetRepo sheetRepo)
        {
            _sheetRepo = sheetRepo;
        }

        public Sheet GetItem(Guid id)
        {
            return _sheetRepo.GetItem(id);
        }
    }
}
