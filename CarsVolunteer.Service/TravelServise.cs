using CarsVolunteer.core.Repositories;
using CarsVolunteer.core.servies;
using CarsVolunteer.Core.Entities;

namespace Project.Servies
{
    public class TravelServise : ItravelServies
    {
        readonly private ITravelRepository _travelRepository;
        public bool AddTravel(Travel travel)
        {
            _travelRepository.AddTravel(travel);
            return true;
        }

        public bool DeleteTravel(int id)
        {
            _travelRepository.DeleteTravel(id);
            return true;
        }

        public List<Travel> GetListOfTravel()
        {
          return _travelRepository.GetListOfTravel().ToList();
             
        }

        public Travel GetTravelById(int id)
        {
           return _travelRepository.GetTravelById(id);            
        }

        public bool UpdateTravel(int id, Travel travel)
        {
            return _travelRepository.UpdateTravel(id, travel);  
        }
    }
}

