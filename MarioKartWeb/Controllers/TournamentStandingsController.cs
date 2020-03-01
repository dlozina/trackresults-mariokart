using AutoMapper;
using MarioKartWeb.Data;
using MarioKartWeb.Helper;
using MarioKartWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MarioKartWeb.Controllers
{
    public class TournamentStandingsController : Controller
    {
        private MarioKartWebContext db = new MarioKartWebContext();

        // GET: Tournament Standings
        public ActionResult Index(string tournamentSelection)
        {

            var drivers = db.Drivers.Where(x => x.Name != "" && x.Name != null);
            var listOfTournaments = db.Tournaments.OrderBy(x => x.ID).ToList();
            var tournamentFirstLoad = db.Tournaments.FirstOrDefault();

            string tournamentName;
            if (!String.IsNullOrEmpty(tournamentSelection))
                tournamentName = tournamentSelection;
            else
                tournamentName = tournamentFirstLoad.TournamentName;


            List<TournamentStandings> standingsList = new List<TournamentStandings>();
            foreach (var driver in db.Drivers)
            {
                var points = CalculateStandingsForAllDrivers(driver.Name, tournamentName);
                standingsList.Add(points);
            }


            var model = StandingsList(standingsList).OrderByDescending(x => x.Points);
            var modelVM = Mapper.Map<IEnumerable<TournamentStandingsViewModel>>(model);

            var vm = new TournamentStandingsIndexViewModel(modelVM);

            foreach (var tournament in listOfTournaments)
            {
                vm.Tournaments.Add(new SelectListItem()
                {
                    Text = tournament.TournamentName,
                    Value = tournament.TournamentName
                });

            }

            vm.TournamentName = tournamentName;

            return View(vm);
        }

        private List<TournamentStandings> StandingsList(List<TournamentStandings> standingsList)
        {
            var sortedStandingsList = standingsList.OrderByDescending(x => x.Points).ToList();
            for (int i = 0; i < sortedStandingsList.Count(); i++)
            {
                sortedStandingsList[i].Position = i + 1;
            }
            standingsList.OrderByDescending(x => x.Points);

            return standingsList;
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

        private TournamentStandings CalculateStandingsForAllDrivers(string driver, string tournamentName)
        {
            TournamentStandings tournamentStandings = new TournamentStandings();
            var driverRaces = db.Races.Where(x => x.Driver.Equals(driver) && x.TournamentName.Equals(tournamentName));

            tournamentStandings.DriverName = driver;
            tournamentStandings.Points = DriverPointsCalculation(driverRaces);

            return tournamentStandings;
        }
    }
}