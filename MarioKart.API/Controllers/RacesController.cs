using MarioKartService.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MarioKart.API.Controllers
{
    //[Authorize]
    [RoutePrefix("api")]
    public class RacesController : ApiController
    {
        private readonly ITournaments tournamentsService;
        private readonly IDrivers driversService;
        private readonly IRaces racesService;

        public RacesController(ITournaments tournamentsService, IDrivers driversService, IRaces racesService)
        {
            this.tournamentsService = tournamentsService;
            this.driversService = driversService;
            this.racesService = racesService;
        }

        [Route("races")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var races = racesService.GetRaces().OrderByDescending(x => x.RaceDate);
            try
            {
                if (races == null)
                    return NotFound();
                else
                    return Ok(races);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("races")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] Model.Race race)
        {
            try
            {
                if (race == null)
                    return BadRequest();


                // Dodavanje drivera
                var result = racesService.SaveNewRace(race);

                if (result == 1)
                    return Created(Request.RequestUri + "/" + race.ID.ToString(), race);

                return BadRequest();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("races")]
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Model.Race race)
        {
            try
            {
                if (race == null)
                    return BadRequest();

                // if you find it and then modify it is sored in the context and you get modif error
                //var result = driversService.GetDrivers().Find(id);

                // Update
                var result = racesService.EditRace(race); ;
                if (result == 1)
                    return Ok(race);

                else if (result != 1)
                    return NotFound();


                return BadRequest();

            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("races")]
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {

                var race = racesService.GetRaces().Find(id);

                if (race != null)
                {
                    var result = racesService.DeleteRace(race); 
                    if (result == 1)
                        return StatusCode(HttpStatusCode.NoContent);
                    else
                        return StatusCode(HttpStatusCode.InternalServerError);
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
