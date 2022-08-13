using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер сотрудников
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeesController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpPost("add")]
        public IActionResult Add()
        {
            return Ok();
        }

        [HttpGet("get/{id:Guid}")]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpDelete("delete/{id:guid}")]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
