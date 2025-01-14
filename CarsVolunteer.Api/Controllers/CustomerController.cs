using Microsoft.AspNetCore.Mvc;
using CarsVolunteer.core.servies;
using CarsVolunteer.Core.Entities;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsVolunteer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServies _customerService;
        public CustomerController(ICustomerServies customerService)
        {
            _customerService = customerService;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.GetListOfCustomer();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return _customerService.GetCustomerById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Customer c)
        {
            return _customerService.AddCustomer(c);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] Customer c)
        {
            return _customerService.UpdateCustomer(id, c);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _customerService.DeleteCustomer(id);
        }
    }
}
