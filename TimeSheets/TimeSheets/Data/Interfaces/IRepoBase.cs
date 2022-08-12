using TimeSheets.Models.Dto.Interfaces;

namespace TimeSheets.Data.Interfaces
{
    public interface IRepoBase<T>
    {        
        Task<T> GetItemAsync(Guid id);
        Task<IEnumerable<T>> GetItemsAsync();
        Task<IEnumerable<T>> GetItemsAsync(int skip, int take);
        Task<bool> AddAsync(T Item);
        Task<bool> UpdateAsync(T item);
        Task<bool> RemoveAsync(Guid id);
    }
}
