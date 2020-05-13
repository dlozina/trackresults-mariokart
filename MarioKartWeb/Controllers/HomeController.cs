using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarioKartWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrivers driversService;
        private readonly IStandingsCalculation standingsService;

        public HomeController(IDrivers driversService, IStandingsCalculation standingsService)
        {
            this.driversService = driversService;
            this.standingsService = standingsService;
        }

        public ActionResult Index()
        {
            var drivers = driversService.GetDrivers();
            var totalNumberOfRaces = standingsService.CalculateTotalNumberOfRaces();
            List<HomeViewModel> vms = new List<HomeViewModel>();

            foreach (var driver in drivers)
            {
                HomeViewModel vm = new HomeViewModel();
                var standings = standingsService.CalculateStandingsForAllDrivers(drivers, totalNumberOfRaces);
                vm.ID = driver.ID;
                vm.Position = standings.Where(x => x.DriverName.Equals(driver.Name)).Select(y => y.Position).FirstOrDefault();
                vm.Name = driver.Name;
                vms.Add(vm);
            }

            return View(vms);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Test for Aajax
        public ActionResult Ajax(string pers)
        {
            return Json(pers);
        }
    }
}