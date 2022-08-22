using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Services.Interfaces
{
    public interface ILoginManager
    {
        Task<LoginResponse> Authenticate(User user);

    }
}
