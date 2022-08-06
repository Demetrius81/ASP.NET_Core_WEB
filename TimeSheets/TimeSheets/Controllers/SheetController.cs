using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SheetController : ControllerBase
    {
        private readonly ISheetManager _sheetManager;

        public SheetController(ISheetManager sheetManager)
        {
            _sheetManager = sheetManager;
        }

        [HttpGet("id/{id:Guid}")]
        public IActionResult Get([FromRoute]Guid id)
        {
            var result = _sheetManager.GetItem(id);

            return Ok(result);
        }
    }
}
