using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Data.Interfaces
{
    public interface IRepoBase<T>
    {
        T GetItem(Guid id);
        IEnumerable<T> GetItems();
        IEnumerable<T> GetItems(int skip, int take);
        void Add(T Item);
        void Update(Guid id, T item);
        void Remove(Guid id);
    }
}
