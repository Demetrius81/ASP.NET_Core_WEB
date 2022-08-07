using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер пользователей
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        /// <summary>
        /// Метод добавляет пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public IActionResult Add([FromBody] UserRequest request)
        { 
            Guid response = _userManager.AddItem(request);
           

            if (response == default)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        /// <summary>
        /// Метод возвращает пользователя по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод возвращает пользователя по имени пользователя
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Метод возвращает коллекцию пользователей в указанном количестве, при этом пропускает указанное количество
        /// </summary>
        /// <param name="skip">Сколько пропустить</param>
        /// <param name="take">Сколько вывести</param>
        /// <returns></returns>
        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public IActionResult Get([FromRoute] int skip = 5, int take = 10)
        {
            var users = _userManager.GetItems(skip, take);

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        /// <summary>
        /// Метод обновляет данные пользователя
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public IActionResult Update([FromBody] UserRequest request)
        {
            bool flag = _userManager.UpdateItem(request);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }

        /// <summary>
        /// Метод удаляет пользователя
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            bool flag = _userManager.DeleteItem(id);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
