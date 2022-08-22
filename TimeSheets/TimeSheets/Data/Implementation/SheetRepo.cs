using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class SheetRepo : ISheetRepo
    {
        private readonly TimeSheetDbContext _instance;

        public SheetRepo(TimeSheetDbContext instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Sheet Item)
        {
            if (Item == null)
            {
                return false;
            }

            await _instance.Sheets.AddAsync(Item);

            return true;
        }

        public async Task<Sheet> GetItemAsync(Guid id)
        {
            return _instance.Sheets.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Sheet> GetItemAsyncByDate(DateTime date)
        {
            return _instance.Sheets.FirstOrDefault(x => x.Date == date);
        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync()
        {
            return _instance.Sheets;
        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync(int skip, int take)
        {
            int count = _instance.Sheets.Count();

            if (skip >= count)
            {
                return null;
            }

            if ((skip + take) > count)
            {
                take = count - skip;
            }

            var sheets = _instance.Sheets.Skip(skip).Take(take).ToList();

            return sheets;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Sheet? sheet = _instance.Sheets.FirstOrDefault(x => x.Id == id);

            if (sheet is not null)
            {
                _instance.Sheets.Remove(sheet);

                await _instance.SaveChangesAsync();

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Sheet item)
        {
            Sheet? sheet = _instance.Sheets.FirstOrDefault(x => x.Id == item.Id);

            if (sheet == null)
            {
                return false;
            }

            _instance.Sheets.Update(sheet);

            await _instance.SaveChangesAsync();

            return true;
        }
    }
}
