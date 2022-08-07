using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class UserRepo : IUserRepo
    {
        private readonly TempData _instance;

        public UserRepo(TempData instance)
        {
            _instance = instance;
        }

        public bool Add(User Item)
        {
            if (Item == null)
            {
                return false;
            }

            _instance.users.Add(Item);

            return true;
        }

        public User GetItem(Guid id)
        {
            return _instance.users.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetItems()
        {
            return _instance.users;
        }

        public IEnumerable<User> GetItems(int skip, int take)
        {
            if (skip >= _instance.users.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.users.Count)
            {
                take = _instance.users.Count - skip;
            }

            var users = GetSomeItems(skip, take);

            return users;
        }

        public bool Remove(Guid id)
        {
            User? user = _instance.users.FirstOrDefault(x => x.Id == id);

            if (user is not null)
            {
                _instance.users.Remove(user);

                return true;
            }

            return false;
        }

        public bool Update(User item)
        {
            User? user = _instance.users.FirstOrDefault(x => x.Id == item.Id);

            if (user == null)
            {
                return false;
            }

            _instance.users.Remove(user);

            _instance.users.Add(item);

            return true;
        }

        private IEnumerable<User> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance.users[i];
            }
        }
    }
}
