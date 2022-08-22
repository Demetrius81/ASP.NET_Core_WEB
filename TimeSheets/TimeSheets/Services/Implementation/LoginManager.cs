using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class LoginManager : ILoginManager
    {
        public async Task<LoginResponse> Authenticate(User user)
        {
            throw new NotImplementedException();
        }
    }
}
