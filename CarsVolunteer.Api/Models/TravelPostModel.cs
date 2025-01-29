using CarsVolunteer.Core.Entities;

namespace CarsVolunteer.Api.Models
{
    public class TravelPostModel
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
