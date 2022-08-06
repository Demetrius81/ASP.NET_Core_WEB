using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("add")]
        public IActionResult Add([FromBody] UserRequest request)
        {
            Guid response = default;

            if (request is not null)
            {
                response = _userManager.AddItem(request);
            }

            if (response == default)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        [HttpGet("id/{id:Guid}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            var user = _userManager.GetItem(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("search/{name}")]
        public IActionResult Get([FromRoute] string name)
        {
            var user = _userManager.GetItem(name);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public IActionResult Get([FromRoute] int skip = 5, int take = 10)
        {
            var user = _userManager.GetItems(skip, take);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
