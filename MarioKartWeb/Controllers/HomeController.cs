using MarioKart.Model.HelperClass;
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
        private readonly IAppInformations appInformationsService;

        public HomeController(IDrivers driversService, IStandingsCalculation standingsService, IAppInformations appInformationsService)
        {
            this.driversService = driversService;
            this.standingsService = standingsService;
            this.appInformationsService = appInformationsService;
        }

        public ActionResult Index()
        {
            var drivers = driversService.GetDrivers();
            var totalNumberOfRaces = standingsService.CalculateTotalNumberOfRaces();
            var standings = standingsService.CalculateStandingsForAllDrivers(drivers, totalNumberOfRaces);
            var latestAnnouncement = appInformationsService.GetLatestAnnouncement();
            var getLatestNews = appInformationsService.GetLatestNews();
            // To do Display last 3 news entries
            //var getLatestNoOfNews = appInformationsService.GetLastNoOfNews(3);

            HomeViewModel vm = new HomeViewModel();

            vm.FirstPosition = standings.FirstOrDefault(x => x.Position == 1).DriverName;
            vm.SecondPosition = standings.FirstOrDefault(x => x.Position == 2).DriverName;
            vm.ThirdPosition = standings.FirstOrDefault(x => x.Position == 3).DriverName;
            vm.FourthPosition = standings.FirstOrDefault(x => x.Position == 4).DriverName;
            vm.FifthPosition = standings.FirstOrDefault(x => x.Position == 5).DriverName;

            vm.Title = latestAnnouncement.Title;
            vm.TournamentName = latestAnnouncement.TournamentName;
            vm.TournamentDate = DateTime.Parse(latestAnnouncement.TournamentDate.ToString());
            vm.TournamentTime = DateTime.Parse(latestAnnouncement.TournamentTime.ToString());
            vm.TournamentCallTime = DateTime.Parse(latestAnnouncement.TournamentCallTime.ToString());

            vm.NewsDate = DateTime.Parse(getLatestNews.DateEntered.ToString());
            vm.NewsTitle = getLatestNews.NewsTitle;
            vm.NewsStory = getLatestNews.NewsStory;

            return View(vm);
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