using AutoMapper;
using CarsVolunteer.Api.Models;
using CarsVolunteer.core.servies;
using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core.Entities;
﻿using CarsVolunteer.Core.Entities;
using CarsVolunteer.core.servies;
using Microsoft.AspNetCore.Mvc;
namespace CarsVolunteer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        readonly private ItravelServies _travelServies;
        readonly private IMapper _mapper;
        public TravelController(ItravelServies travelServies, IMapper mapper)
        {
            _travelServies = travelServies;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<Travel> Get()
        {
            var list = _travelServies.GetListOfTravel();
            var listDto = _mapper.Map<IEnumerable<TravelDto>>(list);
            return Ok(listDto);
        }


        [HttpGet("{id}")]
        public ActionResult<Travel> Get(int id)
        {
            var travel = _travelServies.GetTravelById(id);
            var travelDto = _mapper.Map<TravelDto>(travel);
            return Ok(travelDto);
        }


        [HttpPost]
        public ActionResult<bool> Post([FromBody] TravelPostModel travel)
        {
            var travelToAdd = new Travel { Destination = travel.Destination, DetailsOfCar = travel.DetailsOfCar, Id = travel.Id, IdOfCustomer = travel.IdOfCustomer, IdOfVolunteer = travel.IdOfVolunteer, Source = travel.Source, TimeOfTraveling = travel.TimeOfTraveling };
            return _travelServies.AddTravel(travelToAdd);
        }


        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Travel travel)
        {
            return _travelServies.UpdateTravel(id, travel);
        }


        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _travelServies.DeleteTravel(id);
        }
    }
}