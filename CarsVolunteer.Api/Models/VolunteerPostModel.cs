using CarsVolunteer.Core.Entities;

namespace CarsVolunteer.Api.Models
{
    public class VolunteerPostModel
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
