using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using TimeSheets.Infrastucture.Extentions;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Models.Dto.Auth;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Services.Implementation
{
    public class LoginManager : ILoginManager
    {
        private readonly JwtAccessOptions _jwtAccessOptions;

        public LoginManager(IOptions<JwtAccessOptions> jwtAccessOptions)
        {
            _jwtAccessOptions = jwtAccessOptions.Value;
        }

        public async Task<LoginResponse> Authenticate(User user)
        {
            IList<Claim> claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role)
            };

            JwtSecurityToken? accessTokenRaw = _jwtAccessOptions.GenerateToken(claims);
            JwtSecurityTokenHandler? securityHandler = new JwtSecurityTokenHandler();
            string? accessToken = securityHandler.WriteToken(accessTokenRaw);

            LoginResponse? response = new LoginResponse()
            {
                AccessToken = accessToken,
                RefreshToken = "",
                ExpiresIn = accessTokenRaw.ValidTo.ToEpochTime()
            };

            return response;
        }
    }
}
