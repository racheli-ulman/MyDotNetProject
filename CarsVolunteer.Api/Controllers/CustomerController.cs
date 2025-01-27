using Microsoft.AspNetCore.Mvc;
using CarsVolunteer.core.servies;
using CarsVolunteer.Core.Entities;
using CarsVolunteer.Api.Models;
using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core;
using AutoMapper;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsVolunteer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServies _customerService;
        //private readonly Mapping _mapping;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerServies customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<Customer> Get()
        {
            
            var list = _customerService.GetListOfCustomer();
            var listDto=_mapper.Map<IEnumerable<CustomerDto>>(list);
            return Ok(listDto);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            var customerDto= _mapper.Map<CustomerDto>(customer);
            return Ok(customerDto);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] CustomerPostModel c)
        {
            var customerToAdd = new Customer { Address = c.Address, Destination = c.Destination, Email = c.Email, Id = c.Id, Name = c.Name, Phone = c.Phone };
            return _customerService.AddCustomer(customerToAdd);
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
