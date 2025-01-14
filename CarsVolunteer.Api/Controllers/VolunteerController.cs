using CarsVolunteer.core.servies;
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
        public VolunteerController(IVolunteerServies volunteerServies)
        {
            _volunteerServies=volunteerServies;
        }
        // GET: api/<Volunteer>
        [HttpGet]
        public IEnumerable<Volunteer> Get()
        {
            return _volunteerServies.GetListOfVolunteer();
        }

        // GET api/<Volunteer>/5
        [HttpGet("{id}")]
        public Volunteer Get(int id)
        {
            return _volunteerServies.GetVolunteerById(id);
        }

        // POST api/<Volunteer>
        [HttpPost]
        public bool  Post([FromBody] Volunteer volunteer)
        {
             return _volunteerServies.AddVolunteer(volunteer);
        }

        // PUT api/<Volunteer>/5
        [HttpPut("{id}")]
        public bool  Put(int id, [FromBody] Volunteer volunteer)
        {
           return _volunteerServies.UpdateVolunteer(volunteer.Id,volunteer);
        }

        // DELETE api/<Volunteer>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _volunteerServies.DeleteVolunteer(id);
        }
    }
}
