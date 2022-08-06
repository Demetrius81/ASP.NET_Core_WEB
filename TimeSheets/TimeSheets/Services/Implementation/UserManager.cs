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
                UserName = request.UserName
            };

            _userRepo.Add(user);

            return user.Id;
        }

        public void DeleteItem(Guid id)
        {
            _userRepo.Remove(id);
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

        public void UpdateItem(UserRequest request)
        {
            User? user = _userRepo.GetItems().FirstOrDefault(x => x.UserName == request.UserName);


        }
    }
}
