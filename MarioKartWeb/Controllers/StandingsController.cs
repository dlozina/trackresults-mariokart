using MarioKartWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.DataTransferObjects.Standings;

namespace MarioKartWeb.Controllers
{
    public class StandingsController : Controller
    {
        private readonly IStandingsCalculation standingsCalculation;
        private readonly IDrivers driversService;

        public StandingsController(IStandingsCalculation standingsCalculation, IDrivers driversService)
        {
            this.standingsCalculation = standingsCalculation;
            this.driversService = driversService;
        }
        // GET: Standings
        public ActionResult Index()
        {
            var drivers = driversService.GetDrivers();
            var totalNumberOfRaces = standingsCalculation.CalculateTotalNumberOfRaces();

            var model = standingsCalculation.CalculateStandingsForAllDrivers(drivers, totalNumberOfRaces);
            var modelVM = Mapper.Map<IEnumerable<StandingsViewModel>>(model);
            var vm = new StandingsIndexViewModel(modelVM);

            return View(vm);
        }
    }
}