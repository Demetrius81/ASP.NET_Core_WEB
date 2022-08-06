using TimeSheets.Data.Interfaces;
using TimeSheets.Models;

namespace TimeSheets.Data.Implementation
{
    public class UserRepo : IUserRepo
    {
        private List<User> _instance = new List<User>()
        {
            new User()
            {
                Id = Guid.Parse("5824A045-0AEC-F785-D21D-71ABE298F4A9"),
                UserName = "Quinlan"
            },
            new User()
            {
                Id = Guid.Parse("10197B7E-C6B9-960A-E7F3-731577591016"),
                UserName = "Giacomo"
            },
            new User()
            {
                Id = Guid.Parse("B9E27F57-B214-1DBA-B51B-BB9ADB03C338"),
                UserName = "Kelly"
            },
            new User()
            {
                Id = Guid.Parse("BB6A545E-1902-73A6-FCA5-1B82A71683A9"),
                UserName = "Megan"
            },
            new User()
            {
                Id = Guid.Parse("C655B78C-45B0-3433-D38A-42A6918DB8E4"),
                UserName = "Tamekah"
            },
            new User()
            {
                Id = Guid.Parse("C8382A98-C3BB-54A0-92A8-1E6B563ABDCB"),
                UserName = "Hamilton"
            },
            new User()
            {
                Id = Guid.Parse("EEC3D70A-5E41-869D-B105-E1FCCE25E55A"),
                UserName = "Blossom"
            },
            new User()
            {
                Id = Guid.Parse("FB0A5D1D-C122-D69E-433F-9C12EC99AFBF"),
                UserName = "Zahir"
            },
            new User()
            {
                Id = Guid.Parse("11DC0EA3-0F47-EB35-4134-66B50E25944A"),
                UserName = "Yuri"
            }
        };

        public void Add(User Item)
        {
            _instance.Add(Item);
        }

        public User GetItem(Guid id)
        {
            return _instance.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<User> GetItems()
        {
            return _instance;
        }

        public IEnumerable<User> GetItems(int skip, int take)
        {
            if (skip >= _instance.Count)
            {
                return null;
            }

            if ((skip + take) > _instance.Count)
            {
                take = _instance.Count - skip;
            }

            return GetSomeItems(skip, take);
        }

        public void Remove(Guid id)
        {
            User? user = _instance.FirstOrDefault(x => x.Id == id);

            if (user is not null)
            {
                _instance.Remove(user);
            }
        }

        public void Update(Guid id, User item)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<User> GetSomeItems(int skip, int take)
        {
            for (int i = skip; i < skip + take; i++)
            {
                yield return _instance[i + 1];
            }
        }
    }
}
