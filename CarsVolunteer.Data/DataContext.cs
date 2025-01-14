using CarsVolunteer.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarsVolunteer.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Travel> travels { get; set; }
        public DbSet<Volunteer> volunteers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=sample_db");
        }
        /*public DataContext()
        {
            customers = new List<Customer>() { new Customer { Id = 1, Name = "User Name", Email = "hi@email.com", Address = "ttt", Destination = "jerusalem", Phone = "34567890" } };

            travels = new List<Travel>() { new Travel(){Destination="Bnei Brak",IdOfVolunteer=4,IdOfCustomer=4,IdOfTravel=4,
             Source="Elad",TimeOfTraveling=new DateTime(12,23,34),
             DetailsOfCar=new Car(){ CountPlacesInCar=9,Id=1,Status=true} } };
            volunteers = new List<Volunteer>() { new Volunteer() {Id=1,Name="Moshe",Address="yeoshua",Email="M000@gmail.com",Phone="0548577747",CountTravelingInMonth=4,
             DetailsOfCar=new Car(){Id=1,CountPlacesInCar=6,Status=false } } };
        }*/
    }
}
