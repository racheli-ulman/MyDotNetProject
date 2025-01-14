namespace CarsVolunteer.Core.Entities
{
    public class Travel
    {
        //קוד לקוח קוד מתנדב קוד פניה תחום תאריךושעה מיקום 
        public int      Id             { get; set; }
        public int      IdOfCustomer   { get; set; }
        public int      IdOfVolunteer   { get; set; }
        public DateTime TimeOfTraveling { get; set; }
        public string   Source          { get; set; }
        public string   Destination      { get; set; }
        public Car      DetailsOfCar    { get; set; }

        public Travel()
        {
            
        }
        public Travel(int idOfVolunteer, DateTime timeOfTraveling, string source, string destination, Car detailsOfCar, int id)
        {
            IdOfVolunteer = idOfVolunteer;
            TimeOfTraveling = timeOfTraveling;
            this.Source = source;
            this.Destination = destination;
            DetailsOfCar = detailsOfCar;
            Id = id;
        }
    }
}
