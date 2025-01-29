using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsVolunteer.Core.Entities;

namespace CarsVolunteer.core.Repositories
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetListOfCustomer();
        public Customer GetCustomerById(int id);
        public bool AddCustomer(Customer customer);
        public bool DeleteCustomer(int id);
        public bool UpdateCustomer(int id, Customer customer);
    }
}
