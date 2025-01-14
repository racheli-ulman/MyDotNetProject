using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Data.Repositories
{
    public class TravelRepository:ITravelRepository
    {
        private readonly DataContext _dataContext;

        public TravelRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddTravel(Travel travel)
        {
            _dataContext.travels.Add(travel);
            return true;
        }

        public bool DeleteTravel(int id)
        {
            _dataContext.travels.Remove(GetTravelById(id));
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
            DeleteTravel(id);
            AddTravel(travel);
            return true;
        }
    }
}
