using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Data.Repositories
{
    public class TravelRepository : ITravelRepository
    {
        private readonly DataContext _dataContext;

        public TravelRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddTravel(Travel travel)
        {
            _dataContext.travels.Add(travel);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteTravel(int id)
        {
            var existVolunteer = GetTravelById(id);
            if (existVolunteer == null)
            {
                Console.WriteLine("there isn't this customer");
                return false;
            }
            _dataContext.travels.Remove(existVolunteer);
            _dataContext.SaveChanges();
            return true;
        }

        public List<Travel> GetListOfTravel()
        {
            return _dataContext.travels.ToList();
        }

        public Travel GetTravelById(int id)
        {
            return _dataContext.travels.ToList().Find(x => x.DetailsOfCar.Id == id);
        }

        public bool UpdateTravel(int id, Travel travel)
        {
            var existTravel = GetTravelById(id);

            existTravel.Id = existTravel.Id;
            existTravel.IdOfCustomer = existTravel.IdOfCustomer;
            existTravel.IdOfVolunteer = existTravel.IdOfVolunteer;
            existTravel.TimeOfTraveling = existTravel.TimeOfTraveling;
            existTravel.Source = existTravel.Source;
            existTravel.Destination = existTravel.Destination;
            existTravel.DetailsOfCar.Id = existTravel.DetailsOfCar.Id;
            existTravel.DetailsOfCar.Status = existTravel.DetailsOfCar.Status;
            existTravel.DetailsOfCar.CountPlacesInCar = existTravel.DetailsOfCar.CountPlacesInCar;

            _dataContext.SaveChanges();
            return true;
        }
    }
}
