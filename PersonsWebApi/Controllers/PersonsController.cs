using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsWebApi.Application.DataTransferObject;
using PersonsWebApi.Application.Interfaces;
using PersonsWebApi.Domain.Paging;

namespace PersonsWebApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PersonDto dto)
        {
            return Ok(await _personService.AddAsync(dto));
        }

        [HttpGet]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            return Ok(await _personService.GetByIdAsync(id));
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] PagingParameters paging)
        {
            return Ok(_personService.GetAll(paging));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] PersonDto dto)
        {
            return Ok(await _personService.UpdateAsync(dto));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromQuery] int id)
        {
            await _personService.DeleteAsync(id);
            return Ok();
        }
    }
}
