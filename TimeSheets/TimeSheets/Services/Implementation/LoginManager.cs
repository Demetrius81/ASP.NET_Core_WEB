using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class LoginManager : ILoginManager
    {
        public async Task<LoginResponse> Authenticate(User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };
        }
    }
}
