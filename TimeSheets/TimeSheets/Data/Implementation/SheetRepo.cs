using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class SheetRepo : ISheetRepo
    {
        public void Add(Sheet Item)
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

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Guid id, Sheet item)
        {
            throw new NotImplementedException();
        }
    }
}
