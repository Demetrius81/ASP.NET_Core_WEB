using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Data.Interfaces
{
    public interface IRepoBase<T>
    {
        T GetItem(Guid id);
        IEnumerable<T> GetItems();
        IEnumerable<T> GetItems(int skip, int take);
        bool Add(T Item);
        bool Update(T item);
        bool Remove(Guid id);
    }
}
