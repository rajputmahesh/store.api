using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using store.datalayer.DbAccess;

namespace store.api.Controllers
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
        private readonly StoreDbContext _storeDbContext;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, StoreDbContext storeDbContext)
        {
            _logger = logger;
            _storeDbContext = storeDbContext;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var userInfo = _storeDbContext.UserInfo.Where(u => u.Id == 1);



            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
