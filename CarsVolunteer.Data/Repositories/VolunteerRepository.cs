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
    public class VolunteerRepository : IVolunteerRepository
    {
        private readonly DataContext _dataContext;
        public VolunteerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Volunteer> GetListOfVolunteer()
        {
            return _dataContext.volunteers.Include(u=>u.travelList).ToList();
        }

        public Volunteer GetVolunteerById(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteVolunteer(int id)
        {
            var existVolunteer = GetVolunteerById(id);
            if (existVolunteer == null)
            {
                Console.WriteLine("there isn't this customer");
                return false;
            }
            _dataContext.volunteers.Remove(existVolunteer);
            _dataContext.SaveChanges();
            return true;
        }

        public bool AddVolunteer(Volunteer volunteer)
        {
            _dataContext.volunteers.Add(volunteer);
            _dataContext.SaveChanges();
            return true;
        }

        public bool UpdateVolunteer(int id, Volunteer volunteer)
        {
            var existVolunteer = GetVolunteerById(id);
            if (existVolunteer == null)
            {
                Console.WriteLine("there isn't this volunteer");
                return false;
            }
            existVolunteer.Email = existVolunteer.Email;
            existVolunteer.Address = existVolunteer.Address;
            existVolunteer.Phone = existVolunteer.Phone;
            existVolunteer.Name = existVolunteer.Name;
            existVolunteer.CountTravelingInMonth = existVolunteer.CountTravelingInMonth;
            existVolunteer.DetailsOfCar.Id = existVolunteer.Id;
            existVolunteer.DetailsOfCar.CountPlacesInCar = existVolunteer.DetailsOfCar.CountPlacesInCar;
            existVolunteer.DetailsOfCar.Status = existVolunteer.DetailsOfCar.Status;
            _dataContext.SaveChanges();
            return true;
        }
    }
}
