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
    public class VolunteerController : ControllerBase
    {
        private readonly IVolunteerServies _volunteerServies;
        private readonly IMapper _mapper;
        public VolunteerController(IVolunteerServies volunteerServies,IMapper mapper)
        {
            _volunteerServies = volunteerServies;
            _mapper = mapper;
        }
        // GET: api/<Volunteer>
        [HttpGet]
        public ActionResult<Volunteer> Get()
        {
            var list = _volunteerServies.GetListOfVolunteer();
            var listDto = _mapper.Map<IEnumerable<VolunteerDto>>(list);
            return Ok(listDto);
        }

        // GET api/<Volunteer>/5
        [HttpGet("{id}")]
        public ActionResult<Volunteer> Get(int id)
        {
            var volunteer = _volunteerServies.GetVolunteerById(id);
            var volunteerDto = _mapper.Map<VolunteerDto>(volunteer);
            return Ok(volunteerDto);
        }

        // POST api/<Volunteer>
        [HttpPost]
        public bool Post([FromBody] VolunteerPostModel volunteer)
        {
            var volunterrToAdd = new Volunteer { Address = volunteer.Address, CountTravelingInMonth = volunteer.CountTravelingInMonth, DetailsOfCar = volunteer.DetailsOfCar, Email = volunteer.Email, Id = volunteer.Id, Name = volunteer.Name, Phone = volunteer.Phone };
            return _volunteerServies.AddVolunteer(volunterrToAdd);
        }

        // PUT api/<Volunteer>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Volunteer volunteer)
        {
            return _volunteerServies.UpdateVolunteer(volunteer.Id, volunteer);
        }

        // DELETE api/<Volunteer>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _volunteerServies.DeleteVolunteer(id);
        }
    }
}
