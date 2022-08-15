using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class UserRepo : IUserRepo
    {
        private readonly TimeSheetDbContext _instance;

        public UserRepo(TimeSheetDbContext instance)
        {
            _instance = instance;
        }

        public async Task<bool> AddAsync(User Item)
        {
            if (Item == null)
            {
                return false;
            }

            await _instance.Users.AddAsync(Item);

            await _instance.SaveChangesAsync();

            return true;
        }

        public async Task<User> GetItemAsync(Guid id)
        {
            return _instance.Users.FirstOrDefault(x => x.Id == id);
        }

        public async Task<User> GetItemAsyncByName(string name)
        {
            return _instance.Users.FirstOrDefault(x=>x.UserName == name);
        }

        public async Task<IEnumerable<User>> GetItemsAsync()
        {
            return _instance.Users.ToList();
        }

        public async Task<IEnumerable<User>> GetItemsAsync(int skip, int take)
        {
            int count = _instance.Users.Count();

            if (skip >= count)
            {
                return null;
            }

            if ((skip + take) > count)
            {
                take = count - skip;
            }

            List<User> users = _instance.Users.Skip(skip).Take(take).ToList();

            return users;
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            User? user = _instance.Users.FirstOrDefault(x => x.Id == id);

            if (user is not null)
            {
                _instance.Users.Remove(user);

                await _instance.SaveChangesAsync(true);

                return true;
            }

            return false;
        }

        public async Task<bool> UpdateAsync(User item)
        {
            User? user = _instance.Users.FirstOrDefault(x => x.Id == item.Id);

            if (user == null)
            {
                return false;
            }

            _instance.Users.Update(user);

            await _instance.SaveChangesAsync(true);

            return true;
        }
    }
}
