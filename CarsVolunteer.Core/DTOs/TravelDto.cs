using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core.DTOs
{
    public class TravelDto
    {
        public int Id { get; set; }
        public int IdOfCustomer { get; set; }
        public int IdOfVolunteer { get; set; }
        public DateTime TimeOfTraveling { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public Car DetailsOfCar { get; set; }
    }
}
