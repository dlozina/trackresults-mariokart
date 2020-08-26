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
    public class DriversController : ApiController
    {
        private readonly IDrivers driversService;

        public DriversController(IDrivers driversService)
        {
            this.driversService = driversService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var drivers = driversService.GetDrivers().OrderByDescending(x => x.ID);
            try
            {
                if (drivers == null)
                    return NotFound();
                else
                    return Ok(drivers);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
