using Microsoft.AspNetCore.Mvc;

namespace PersonsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
    /*
     [ApiController]
    [Route("api/[controller]/[action]")]
    public class CityController : ControllerBase
    {
        private readonly ICityService _cityService;
        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCity(CityDto dto)
        {
            return Ok(await _cityService.AddCity(dto));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCity(int id)
        {
            return Ok(await _cityService.GetCity(id));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveCity(int id)
        {
            var result = await _cityService.DeleteCity(id);
            if (result.Data == true)
                return Ok(result);
            else
                return NotFound(result);
            
        }
    }
     */
}