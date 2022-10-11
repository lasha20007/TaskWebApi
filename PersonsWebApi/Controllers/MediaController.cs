using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonsWebApi.Application.Interfaces;
using PersonsWebApi.Domain.Entities;

namespace PersonsWebApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly IPhotoService _photoService;

        public MediaController(IPhotoService photoService)
        {
            _photoService = photoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetPhotoByPersonId([FromQuery] int id)
        {
            var photo = await _photoService.GetPhotoByPersonId(id);
            return Ok(photo);
        }

        [HttpPost]
        public async Task<IActionResult> AddPhotoOfPerson([FromForm] PersonPhoto model)
        {
            var photo = await _photoService.AddPhotoOfPerson(model);
            return Ok(photo);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePhotoOfPerson([FromForm] PersonPhoto model)
        {
            var photo = await _photoService.UpdatePhotoOfPerson(model);
            return Ok(photo);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePhotoOfPerson([FromQuery] int id)
        {
            await _photoService.DeletePhotoOfPerson(id);
            return Ok();
        }
    }
}
