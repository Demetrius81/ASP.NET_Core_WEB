using TimeSheets.Data.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepo _userRepo;

        public UserManager(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public Guid AddItem(UserRequest request)
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Company = request.Company,
                Age = request.Age
            };

            bool flag = _userRepo.Add(user);

            if (flag)
            {
                return user.Id;
            }

            return default;
        }

        public bool DeleteItem(Guid id)
        {
            return _userRepo.Remove(id);
        }

        public User GetItem(Guid id)
        {
            return _userRepo.GetItem(id);
        }

        public User GetItem(string Name)
        {
            return _userRepo.GetItems().FirstOrDefault(x => x.UserName == Name);
        }

        public IEnumerable<User> GetItems(int skip, int take)
        {
            return _userRepo.GetItems(skip, take);
        }

        public bool UpdateItem(UserRequest request)
        {
            User? userFromDb = _userRepo.GetItems().FirstOrDefault(x => x.UserName == request.UserName);

            if (userFromDb == null)
            {
                return false;
            }

            User user = new User()
            {
                Id = userFromDb.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Company = request.Company,
                Age = request.Age
            };

            bool flag = _userRepo.Update(user);

            return flag;
        }
    }
}
