using MarioKartService.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MarioKart.API.Helpers;

namespace MarioKart.API.Controllers
{
    //[Authorize]
    [RoutePrefix("api")]
    public class DriversController : ApiController
    {
        private readonly IDrivers driversService;

        public DriversController(IDrivers driversService)
        {
            this.driversService = driversService;
        }

        [Route("drivers")]
        [HttpGet]
        public IHttpActionResult Get(string sort = "id")
        {
            var drivers = driversService.GetDrivers().ApplySort(sort);
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

        [Route("drivers")]
        [HttpPost]
        public IHttpActionResult Post([FromBody] Model.Driver driver)
        {
            try
            {
                if (driver == null)
                {
                    return BadRequest();
                }

                // Dodavanje drivera
                var result = driversService.SaveNewDriver(driver);

                if (result == 1)
                {
                    return Created(Request.RequestUri + "/" + driver.ID.ToString(), driver);
                }

                return BadRequest();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("drivers")]
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Model.Driver driver)
        {
            try
            {
                if (driver == null)
                    return BadRequest();

                var result = driversService.GetDrivers().Find(id);

                if (result != null)
                {
                    // Update
                    driversService.EditDriver(driver);
                    return Ok(result);
                }
                else if (result == null)
                {
                    return NotFound();
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
