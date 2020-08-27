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
    public class StandingsController : ApiController
    {
        private readonly IStandingsCalculation standingsCalculation;
        private readonly IDrivers driversService;

        public StandingsController(IStandingsCalculation standingsCalculation, IDrivers driversService)
        {
            this.standingsCalculation = standingsCalculation;
            this.driversService = driversService;
        }

        [Route("standings")]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var drivers = driversService.GetDrivers();
            var totalNumberOfRaces = standingsCalculation.CalculateTotalNumberOfRaces();

            var result = standingsCalculation.CalculateStandingsForAllDrivers(drivers, totalNumberOfRaces).OrderBy(p => p.Position);

            try
            {
                if (result == null)
                    return NotFound();
                else
                    return Ok(result);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }


    }
}
