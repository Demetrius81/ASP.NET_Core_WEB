using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Services.Interfaces;
using TimeSheets.Models;
using TimeSheets.Models.Dto;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер клиентов
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientManager _clientManager;

        public ClientsController(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        /// <summary>
        /// Метод добавляет клиента
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] ClientRequest request)
        {
            Guid response = await _clientManager.AddItemAsync(request);

            if (response == default)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        /// <summary>
        /// Метод возвращает клиента по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get/{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            Client user = await _clientManager.GetItemAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Метод возвращает коллекцию клиентов в указанном количестве, при этом пропускает указанное количество
        /// </summary>
        /// <param name="skip">Сколько пропустить</param>
        /// <param name="take">Сколько вывести</param>
        /// <returns></returns>
        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public async Task<IActionResult> Get([FromRoute] int skip = 5, int take = 10)
        {
            IEnumerable<Client> users = await _clientManager.GetItemsAsync(skip, take);

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        /// <summary>
        /// Метод обновляет данные клиента
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        //[HttpPut("update")]
        //public async Task<IActionResult> Update([FromBody] ClientRequest request)
        //{

        //    return Ok();

        //}

        /// <summary>
        /// Метод удаляет клиента
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            bool flag = await _clientManager.DeleteItemAsync(id);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
