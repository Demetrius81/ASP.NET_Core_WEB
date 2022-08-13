using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Models;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    //[Route("[controller]")]
    //[ApiController]
    //public class SheetsController : ControllerBase
    //{
    //    private readonly ISheetManager _sheetManager;

    //    public SheetsController(ISheetManager sheetManager)
    //    {
    //        _sheetManager = sheetManager;
    //    }

    //    [HttpGet("id/{id:Guid}")]
    //    public async Task<IActionResult> Get([FromRoute]Guid id)
    //    {
    //        Sheet result = await _sheetManager.GetItemAsync(id);

    //        return Ok(result);
    //    }
    //}
}
