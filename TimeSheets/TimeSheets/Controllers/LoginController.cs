using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserManager _userManager;
        private readonly ILoginManager _loginManager;

        public LoginController(ILoginManager loginManager, IUserManager userManager)
        {
            _loginManager = loginManager;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            User user = await _userManager.GetItemAsync(request);

            if (user == null)
            {
                return Unauthorized();
            }

            var loginResponse = await _loginManager.Authenticate(user);
        }
    }
}
