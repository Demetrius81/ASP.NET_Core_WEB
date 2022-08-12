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

        public async Task<User> GetItemAsync(Guid id)
        {
            return await _userRepo.GetItemAsync(id);
        }

        public async Task<User> GetItemAsync(string Name)
        {
            IEnumerable<User> users = await _userRepo.GetItemsAsync();

            return users.FirstOrDefault(x => x.UserName == Name);
        }

        public async Task<IEnumerable<User>> GetItemsAsync(int skip, int take)
        {
            return await _userRepo.GetItemsAsync(skip, take);
        }
        public async Task<Guid> AddItemAsync(UserRequest request)
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

            bool flag = await _userRepo.AddAsync(user);

            return flag ? user.Id : default;
        }

        public async Task<bool> UpdateItemAsync(UserRequest request)
        {
            IEnumerable<User> users = await _userRepo.GetItemsAsync();

            User? user = users.FirstOrDefault(x => x.UserName == request.UserName);

            if (user == null)
            {
                return false;
            }

            User newUser = new User()
            {
                Id = user.Id,
                UserName = request.UserName,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Company = request.Company,
                Age = request.Age
            };

            bool flag = await _userRepo.UpdateAsync(user);

            return flag;
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            return await _userRepo.RemoveAsync(id);
        }

    }
}
