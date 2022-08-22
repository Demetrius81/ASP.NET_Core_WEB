using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
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

        public async Task<Guid> AddItemAsync(SheetRequest request)
        {
            Sheet sheet = new Sheet()
            {
                Id = Guid.NewGuid(),
                Date = request.Date,
                EmployeeId = request.EmployeeId,
                ContractId = request.ContractId,
                ServiceId = request.ServiceId,
                Amount = request.Amount,
            };

            bool flag = await _sheetRepo.AddAsync(sheet);

            return flag ? sheet.Id : default;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            return await _sheetRepo.RemoveAsync(id);
        }

        public async Task<Sheet> GetItemAsync(Guid id)
        {
            return await _sheetRepo.GetItemAsync(id);
        }

        public async Task<Sheet> GetItemAsync(DateTime date)
        {
            return await _sheetRepo.GetItemAsyncByDate(date);
        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync(int skip, int take)
        {
            return await _sheetRepo.GetItemsAsync(skip, take);
        }

        public async Task<bool> UpdateItemAsync(SheetRequest request)
        {
            Sheet sheet = await _sheetRepo.GetItemAsyncByDate(request.Date);

            if (sheet == null)
            {
                return false;
            }

            sheet = new Sheet()
            {
                Id = sheet.Id,
                Date = request.Date,
                EmployeeId = request.EmployeeId,
                ContractId = request.ContractId,
                ServiceId = request.ServiceId,
                Amount = request.Amount,
            };

            bool flag = await _sheetRepo.UpdateAsync(sheet);

            return flag;
        }
    }
}
