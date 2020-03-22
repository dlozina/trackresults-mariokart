using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MarioKartWeb.Controllers
{
    public class DriverInfoController : Controller
    {
        private readonly IDrivers driversService;
        private readonly IRaces racesService;
        private readonly ITournaments tournamentsService;

        public DriverInfoController(IDrivers driversService, IRaces racesService, ITournaments tournamentsService)
        {
            this.driversService = driversService;
            this.racesService = racesService;
            this.tournamentsService = tournamentsService;
        }
        // GET: DriverInfo
        public ActionResult Index()
        {
            var drivers = driversService.GetDrivers();
            List<DriverInfoViewModel> vms = new List<DriverInfoViewModel>();

            foreach(var driver in drivers)
            {
                DriverInfoViewModel vm = new DriverInfoViewModel();
                vm.ID = driver.ID;
                vm.Name = driver.Name;
                vms.Add(vm);
            }

            return View(vms);
        }

        public ActionResult DriverDetails(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var driver = driversService.GetDrivers().Find(id);
            DriverInfoViewModel vm = new DriverInfoViewModel();

            vm.Name = driver.Name;
            vm.NumberOfGrandPrixWon = driversService.NumberOfGrandPrixWon(driver.Name);
            vm.NumberOfPoints = driversService.NumberOfPoints(driver.Name);
            vm.GrandPrixEntered = driversService.GrandPrixEntered(driver.Name);
            vm.TournamentsWon = driversService.TournamentsWon(driver.Name);
            vm.FavoriteTrack = driver.FavoriteTrack;
            vm.FavoriteCar = driver.FavoriteCar;
            vm.Description = driver.Description;

            return View(vm);
        }
    }
}