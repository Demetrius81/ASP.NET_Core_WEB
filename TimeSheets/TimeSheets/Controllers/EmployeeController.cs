using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер сотрудников
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeManager _employeeManager;

        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public IActionResult Add()
        {
            return Ok();
        }

        public IActionResult Get()
        {
            return Ok();
        }

        public IActionResult Update()
        {
            return Ok();
        }

        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
