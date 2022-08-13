using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Services.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер услуг
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly ISerrviceManager _serviceManager;

        public ServicesController(ISerrviceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        /// <summary>
        /// Метод добавляет услугу
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] ServiceRequest request)
        {
            Guid response = await _serviceManager.AddItemAsync(request);

            if (response == default)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        /// <summary>
        /// Метод возвращает услугу по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get/{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            Service user = await _serviceManager.GetItemAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Метод возвращает услугу по названию
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("search/{name}")]
        public async Task<IActionResult> Get([FromRoute] string name)
        {
            Service user = await _serviceManager.GetItemAsync(name);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Метод возвращает коллекцию услуг в указанном количестве, при этом пропускает указанное количество
        /// </summary>
        /// <param name="skip">Сколько пропустить</param>
        /// <param name="take">Сколько вывести</param>
        /// <returns></returns>
        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public async Task<IActionResult> Get([FromRoute] int skip = 5, int take = 10)
        {
            IEnumerable<Service> users = await _serviceManager.GetItemsAsync(skip, take);

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        /// <summary>
        /// Метод обновляет данные услуги
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] ServiceRequest request)
        {
            bool flag = await _serviceManager.UpdateItemAsync(request);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }

        /// <summary>
        /// Метод удаляет услугу
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            bool flag = await _serviceManager.DeleteItemAsync(id);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
