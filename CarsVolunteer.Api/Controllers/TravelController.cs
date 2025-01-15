using CarsVolunteer.Core.Entities;
using CarsVolunteer.core.servies;
using Microsoft.AspNetCore.Mvc;
namespace CarsVolunteer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController: ControllerBase
    {
        readonly private ItravelServies _travelServies;
        public TravelController(ItravelServies travelServies)
        {
            _travelServies = travelServies;
        }
  
        [HttpGet]
        public IEnumerable<Travel> Get()
        {
            return _travelServies.GetListOfTravel().ToList();
        }

       
        [HttpGet("{id}")]
        public Travel Get(int id)
        {
            return _travelServies.GetTravelById(id);
        }

    
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Travel travel)
        {
            return _travelServies.AddTravel(travel);
        }

   
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Travel travel)
        {
            return _travelServies.UpdateTravel(id, travel);
        }

    
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _travelServies.DeleteTravel(id);
        }
    }
}
