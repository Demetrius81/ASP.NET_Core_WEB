using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер сотрудников
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeesController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        /// <summary>
        /// Метод добавляет сотрудника
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] EmployeeRequest request)
        {
            Guid response = await _employeeManager.AddItemAsync(request);

            if (response == default)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        /// <summary>
        /// Метод возвращает сотрудника по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get/{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            Employee user = await _employeeManager.GetItemAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
        
        /// <summary>
        /// Метод возвращает коллекцию сотрудников в указанном количестве, при этом пропускает указанное количество
        /// </summary>
        /// <param name="skip">Сколько пропустить</param>
        /// <param name="take">Сколько вывести</param>
        /// <returns></returns>
        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public async Task<IActionResult> Get([FromRoute] int skip = 5, int take = 10)
        {
            IEnumerable<Employee> users = await _employeeManager.GetItemsAsync(skip, take);

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        /// <summary>
        /// Метод обновляет данные сотрудника
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] EmployeeRequest request)
        {
            bool flag = await _employeeManager.UpdateItemAsync(request);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }

        /// <summary>
        /// Метод удаляет сотрудника
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            bool flag = await _employeeManager.DeleteItemAsync(id);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
