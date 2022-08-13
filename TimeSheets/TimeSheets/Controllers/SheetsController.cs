﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeSheets.Models;
using TimeSheets.Models.Dto;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Controllers
{
    /// <summary>
    /// Контроллер табелей
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class SheetsController : ControllerBase
    {
        private readonly ISheetManager _sheetManager;

        public SheetsController(ISheetManager sheetManager)
        {
            _sheetManager = sheetManager;
        }

        /// <summary>
        /// Метод добавляет табель
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] SheetRequest request)
        {
            Guid response = await _sheetManager.AddItemAsync(request);

            if (response == default)
            {
                return BadRequest();
            }

            return Ok(response);
        }

        /// <summary>
        /// Метод возвращает табель по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("get/{id:Guid}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            Sheet user = await _sheetManager.GetItemAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Метод возвращает табель по дате
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("search/{date:DateTime}")]
        public async Task<IActionResult> Get([FromRoute] DateTime date)
        {
            Sheet user = await _sheetManager.GetItemAsync(date);

            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        /// <summary>
        /// Метод возвращает коллекцию табелей в указанном количестве, при этом пропускает указанное количество
        /// </summary>
        /// <param name="skip">Сколько пропустить</param>
        /// <param name="take">Сколько вывести</param>
        /// <returns></returns>
        [HttpGet("skip/{skip:int}/take/{take:int}")]
        public async Task<IActionResult> Get([FromRoute] int skip = 5, int take = 10)
        {
            IEnumerable<Sheet> users = await _sheetManager.GetItemsAsync(skip, take);

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        /// <summary>
        /// Метод обновляет данные табеля
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] SheetRequest request)
        {
            bool flag = await _sheetManager.UpdateItemAsync(request);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }

        /// <summary>
        /// Метод удаляет табель
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("delete/{id:guid}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            bool flag = await _sheetManager.DeleteItemAsync(id);

            if (flag)
            {
                return Ok();
            }

            return BadRequest();
        }
    }
}
