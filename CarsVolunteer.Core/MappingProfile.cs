using AutoMapper;
using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerDto>().ReverseMap();
            CreateMap<Travel,TravelDto>().ReverseMap();
            CreateMap<Volunteer,VolunteerDto>().ReverseMap();
        }
    }
}
