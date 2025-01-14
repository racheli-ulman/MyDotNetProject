using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.core.servies
{
    public interface ICustomerServies
    {
        public IEnumerable<Customer> GetListOfCustomer();
        public Customer GetCustomerById(int id);
        public bool AddCustomer(Customer customer);
        public bool DeleteCustomer(int id);
        public bool UpdateCustomer(int id, Customer customer);
    }
}
