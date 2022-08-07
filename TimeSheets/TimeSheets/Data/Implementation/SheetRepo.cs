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

        public bool Add(Sheet Item)
        {
            throw new NotImplementedException();
        }

        public Sheet GetItem(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sheet> GetItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sheet> GetItems(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Sheet item)
        {
            throw new NotImplementedException();
        }
    }
}
