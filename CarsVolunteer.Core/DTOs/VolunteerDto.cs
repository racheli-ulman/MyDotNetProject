using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarsVolunteer.Core.Entities;


namespace CarsVolunteer.Core.DTOs
{
    public class VolunteerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CountTravelingInMonth { get; set; }
        public Car DetailsOfCar { get; set; }
    }
}
