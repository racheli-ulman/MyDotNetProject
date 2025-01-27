using AutoMapper;
using CarsVolunteer.Api.Models;
using CarsVolunteer.core.servies;
using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        readonly private ItravelServies _travelServies;
        readonly private IMapper _mapper;
        public TravelController(ItravelServies travelServies,IMapper mapper)
        {
            _travelServies = travelServies;
            _mapper = mapper;   
        }
        // GET: api/<TravelControllerr>
        [HttpGet]
        public ActionResult<Travel> Get()
        {
            var list = _travelServies.GetListOfTravel();
            var listDto = _mapper.Map<IEnumerable<TravelDto>>(list);
            return Ok(listDto);
        }

        // GET api/<TravelControllerr>/5
        [HttpGet("{id}")]
        public ActionResult<Travel> Get(int id)
        {
            var travel = _travelServies.GetTravelById(id);
            var travelDto = _mapper.Map<TravelDto>(travel);
            return Ok(travelDto);
        }

        // POST api/<TravelControllerr>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] TravelPostModel travel)
        {
            var travelToAdd=new Travel { Destination = travel.Destination,DetailsOfCar=travel.DetailsOfCar,Id=travel.Id,IdOfCustomer=travel.IdOfCustomer,IdOfVolunteer=travel.IdOfVolunteer,Source=travel.Source,TimeOfTraveling=travel.TimeOfTraveling };
            return _travelServies.AddTravel(travelToAdd);
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
