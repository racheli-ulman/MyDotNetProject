using CarsVolunteer.core.servies;
using CarsVolunteer.Core.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelControllerr : ControllerBase
    {
        readonly private ItravelServies _travelServies;
        public TravelControllerr(ItravelServies travelServies)
        {
            _travelServies = travelServies;
        }
        // GET: api/<TravelControllerr>
        [HttpGet]
        public IEnumerable<Travel> Get()
        {
            return _travelServies.GetListOfTravel();
        }

        // GET api/<TravelControllerr>/5
        [HttpGet("{id}")]
        public Travel Get(int id)
        {
            return _travelServies.GetTravelById(id);
        }

        // POST api/<TravelControllerr>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Travel travel)
        {
            return _travelServies.AddTravel(travel);
        }

        // PUT api/<TravelControllerr>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Travel travel)
        {
            return _travelServies.UpdateTravel(id, travel);
        }

        // DELETE api/<TravelControllerr>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _travelServies.DeleteTravel(id);
        }
    }
}
