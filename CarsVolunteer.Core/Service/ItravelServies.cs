using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.core.servies
{
    public interface ItravelServies
    {
        public List<Travel> GetListOfTravel();
        public Travel GetTravelById(int id);
        public bool AddTravel(Travel travel);
        public bool DeleteTravel(int id);
        public bool UpdateTravel(int id, Travel travel);
    }
}
