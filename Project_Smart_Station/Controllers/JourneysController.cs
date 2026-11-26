using Microsoft.AspNetCore.Mvc;
using Smart_Station_REST.Models;
using Smart_Station_REST.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Smart_Station_REST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JourneysController : ControllerBase
    {

        private readonly IRepository<Journey> _journeyRepository;

        public JourneysController(IRepository<Journey> journeyRepository)
        {
            _journeyRepository = journeyRepository;
        }


        // GET: api/<JourneysController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<JourneysController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JourneysController>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult Post([FromBody] APIJourneyInput value)
        {
            try
            {
                Journey resultingJourney = new Journey() { Id = 0, StartLocation = value.StartLocation, Destination = value.Destination, PrepTime = value.PrepTime, ReplanningTime = value.ReplanningTime, ArrivalTime = ParseTime(value.ArrivalTime, value.Timezone) };
                _journeyRepository.Add(resultingJourney);
                return Created($"/api/journeys/{resultingJourney.Id}", value);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<JourneysController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JourneysController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public void Delete(int id)
        {
        }

        private DateTimeOffset ParseTime(string input, int timeZone)
        {
            string hoursString = input.Substring(0, 2);
            string minutesString = input.Substring(3, 2);
            int hours = Int32.Parse(hoursString);
            int minutes = Int32.Parse(minutesString);

            TimeSpan timeZoneDiff = TimeSpan.FromMinutes(timeZone);

            DateTimeOffset output = new(1970, 1, 1, hours, minutes, 0, timeZoneDiff);

            return output;
        }
    }
}
