using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StationController : ControllerBase
    {
        private readonly ILogger<StationController> _logger;

        public StationController(ILogger<StationController> logger)
        {
            _logger = logger;
        }

        // GET: api/<WeatherStationsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<WeatherStationsController>/5
        [HttpGet("{link}")]
        public string Get(string link)
        {
            return "value";
        }

        // POST api/<WeatherStationsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }        
    }
}
