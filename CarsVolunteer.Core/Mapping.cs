using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core
{
    public  class Mapping
    {
        public  CustomerDto MapToCustomerDto(Customer customer)
        {
            return new CustomerDto { Phone = customer.Phone, Address = customer.Address, Destination = customer.Destination, Email = customer.Email, Id = customer.Id, Name = customer.Name };
        }
    }
}
