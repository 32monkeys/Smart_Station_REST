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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<JourneysController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<JourneysController>
        [HttpPost]
        public ActionResult Post([FromBody] Journey value)
        {
            try
            {
                _journeyRepository.Add(value);
                return Created($"/api/journeys/{value.Id}", value);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // PUT api/<JourneysController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<JourneysController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
