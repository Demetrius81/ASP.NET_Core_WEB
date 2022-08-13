using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class SheetRepo : ISheetRepo
    {
        private readonly TempData _instance;

        public SheetRepo(TempData instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(Sheet Item)
        {
            if (Item == null)
            {
                return false;
            }

            _instance.sheets.Add(Item);

            return true;
        }

        public async Task<Sheet> GetItemAsync(Guid id)
        {
            return _instance.sheets.FirstOrDefault(x => x.Id == id);
        }

        public async Task<Sheet> GetItemAsyncByDate(DateTime date)
        {
            return _instance.sheets.FirstOrDefault(x => x.Date == date);
        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync()
        {
            return _instance.sheets;
        }

        public async Task<IEnumerable<Sheet>> GetItemsAsync(int skip, int take)
        {
            if (skip >= _instance.sheets.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.sheets.Count)
            {
                take = _instance.sheets.Count - skip;
            }

            var sheets = GetSomeItems(skip, take);

            return sheets;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            Sheet? sheet = _instance.sheets.FirstOrDefault(x => x.Id == id);

            if (sheet is not null)
            {
                _instance.sheets.Remove(sheet);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(Sheet item)
        {
            Sheet? sheet = _instance.sheets.FirstOrDefault(x => x.Id == item.Id);

            if (sheet == null)
            {
                return false;
            }

            _instance.sheets.Remove(sheet);

            _instance.sheets.Add(item);

            return true;
        }

        private IEnumerable<Sheet> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance.sheets[i];
            }
        }
    }
}
