using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.core.servies
{
    public interface IVolunteerServies
    {
        public List<Volunteer> GetListOfVolunteer();
        public Volunteer GetVolunteerById(int id);
        public bool AddVolunteer(Volunteer volunteer);
        public bool DeleteVolunteer(int id);
        public bool UpdateVolunteer(int id, Volunteer volunteer);
    }
}
