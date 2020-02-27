using MarioKartWeb.Data;
using MarioKartWeb.Helper;
using MarioKartWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;

namespace MarioKartWeb.Controllers
{
    public class StandingsController : Controller
    {
        private MarioKartWebContext db = new MarioKartWebContext();


        // GET: Standings
        public ActionResult Index()
        {
            var drivers = db.Drivers.Where(x => x.Name != "" && x.Name != null);
            var totalNumberOfRaces = CalculateTotalNumberOfRaces();
            List<Standings> standingsList = new List<Standings>();
            foreach (var driver in db.Drivers)
            {
                var points = CalculateStandingsForAllDrivers(driver.Name, totalNumberOfRaces);
                standingsList.Add(points);
            }
            

            var model = StandingsList(standingsList).OrderByDescending(x => x.Points);
            var modelVM = Mapper.Map<IEnumerable<StandingsViewModel>>(model);
            var vm = new StandingsIndexViewModel(modelVM);
            return View(vm);
        }

        private List<Standings> StandingsList(List<Standings> standingsList)
        {
            var sortedStandingsList = standingsList.OrderByDescending(x => x.Points).ToList();
            for (int i = 0; i < sortedStandingsList.Count(); i++)
            {
                sortedStandingsList[i].Position = i + 1;
            }
            standingsList.OrderByDescending(x => x.Points);

            return standingsList;
        }

        private int CalculateTotalNumberOfRaces()
        {
            int totalNumberOfRaces = 0;
            foreach (var tournament in db.Tournaments)
            {
                totalNumberOfRaces += 5;
            }
            return totalNumberOfRaces;
        }
        private int DriverPointsCalculation(IQueryable<Models.Race> driverRaces)
        {
            int driverPoints = 0;
            foreach (var driverRace in driverRaces)
            {
                driverPoints += driverRace.Points;
            }
            return driverPoints;
        }

        private Standings CalculateStandingsForAllDrivers(string driver, int totalNumberOfRaces)
        {
            Standings standings = new Standings();
            var driverRaces = db.Races.Where(x => x.Driver.Equals(driver));

            standings.DriverName = driver;
            standings.Points = DriverPointsCalculation(driverRaces);
            standings.GrandPrixDriven = driverRaces.Count();
            standings.GrandPrixTotal = totalNumberOfRaces;
            standings.WritersCorner = standings.GrandPrixTotal - driverRaces.Count();

            return standings;
        }

    }
}