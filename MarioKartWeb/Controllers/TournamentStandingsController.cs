using AutoMapper;
using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.DataTransferObjects.Standings;
using MarioKartWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MarioKartWeb.Controllers
{
    public class TournamentStandingsController : Controller
    {
        private readonly ITournaments tournamentsService;
        private readonly IDrivers driversService;

        public TournamentStandingsController(ITournaments tournamentsService, IDrivers driversService)
        {
            this.tournamentsService = tournamentsService;
            this.driversService = driversService;
        }

        // GET: Tournament Standings
        public ActionResult Index(string tournamentSelection)
        {
            var drivers = driversService.GetDrivers();
            var listOfTournaments = tournamentsService.GetTournaments().OrderBy(x => x.ID).ToList();
            var tournamentFirstLoad = tournamentsService.GetTournaments().FirstOrDefault();

            string tournamentName;
            if (!String.IsNullOrEmpty(tournamentSelection))
                tournamentName = tournamentSelection;
            else
                tournamentName = tournamentFirstLoad.TournamentName;

            List<TournamentStandings> standingsList = new List<TournamentStandings>();
            foreach (var driver in drivers)
            {
                var points = tournamentsService.CalculateTournamentStandings(driver.Name, tournamentName);
                standingsList.Add(points);
            }

            var model = tournamentsService.SortStandingsList(standingsList).OrderByDescending(x => x.Points);
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

        // GET: Tournament Standings
        public ActionResult TournamentWinners()
        {
            List<TournamentWinnersViewModel> vms = new List<TournamentWinnersViewModel>();
            var tournaments = tournamentsService.GetTournaments().OrderBy(x => x.ID);

            foreach (var tournament in tournaments)
            {
                TournamentWinnersViewModel vm = new TournamentWinnersViewModel();
                vm.ID = tournament.ID;
                vm.RaceDate = DateTime.Parse(tournament.RaceDate.ToString());
                vm.TournamentName = tournament.TournamentName;
                vm.Winer = tournament.Winer;
                vm.Points = tournament.Points;
                vms.Add(vm);
            }
            return View(vms);
        }
    }
}