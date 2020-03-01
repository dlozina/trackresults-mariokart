using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MarioKartWeb.Data;
using MarioKartWeb.Models;
using MarioKartWeb.ViewModel;

namespace MarioKartWeb.Controllers
{
    public class RacesController : Controller
    {
        private MarioKartWebContext db = new MarioKartWebContext();

        // GET: Races
        public ActionResult Index()
        {
            List<RaceViewModel> vms = new List<RaceViewModel>();
            var races = db.Races.OrderByDescending(x => x.ID);

            foreach(var race in races)
            {
                RaceViewModel vm = new RaceViewModel();
                vm.RaceDate = DateTime.Parse(race.RaceDate.ToString());
                vm.TournamentName = race.TournamentName;
                vm.GrandPrixName = race.GrandPrixName;
                vm.Driver = race.Driver;
                vm.Position = race.Position;
                vm.Points = race.Points;
                vm.ID = race.ID;
                vms.Add(vm);
            }

            return View(vms);
        }

        // GET: Races/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Race race = db.Races.Find(id);
            if (race == null)
            {
                return HttpNotFound();
            }
            return View(race);
        }

        // GET: Races/Create
        public ActionResult Create()
        {
            RaceViewModel vm = new RaceViewModel();
            
            var listOfTournaments = db.Tournaments.OrderBy(x => x.ID).ToList();
            var listOfGrandPrixs = db.GrandPrixes.OrderBy(x => x.ID).ToList();
            var listOfDrivers = db.Drivers.OrderBy(x => x.Name).ToList();

            string dateTimeNow = DateTime.Now.ToString("dd.MM.yyyy");
            DateTime date = DateTime.ParseExact(dateTimeNow, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
            vm.RaceDate = date;

            var lastRace = db.Races.OrderByDescending(x => x.ID).First();

            foreach (var tournament in listOfTournaments)
            {
                vm.Tournaments.Add(new SelectListItem()
                {
                    Text = tournament.TournamentName,
                    Value = tournament.TournamentName
                });

            }
            vm.TournamentName = lastRace.TournamentName;

            foreach (var grandPrix in listOfGrandPrixs)
            {
                vm.GrandPrixs.Add(new SelectListItem()
                {
                    Text = grandPrix.Name,
                    Value = grandPrix.Name
                });

            }
            vm.GrandPrixName = lastRace.GrandPrixName;

            foreach (var driver in listOfDrivers)
            {
                vm.Drivers.Add(new SelectListItem()
                {
                    Text = driver.Name,
                    Value = driver.Name
                });

            }

            return View(vm);
        }

        // POST: Races/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RaceViewModel vm)
        {
            var model = Mapper.Map<Race>(vm);

            if (ModelState.IsValid)
            {
                db.Races.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Races/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var entryId = db.Races.FirstOrDefault(x => x.ID == id);
            if (entryId == null)
            {
                return HttpNotFound();
            }

            RaceViewModel vm = new RaceViewModel();

            var listOfTournaments = db.Tournaments.OrderBy(x => x.ID).ToList();
            var listOfGrandPrixs = db.GrandPrixes.OrderBy(x => x.ID).ToList();
            var listOfDrivers = db.Drivers.OrderBy(x => x.Name).ToList();

            vm.RaceDate = DateTime.Parse(entryId.RaceDate.ToString());

            foreach (var tournament in listOfTournaments)
            {
                vm.Tournaments.Add(new SelectListItem()
                {
                    Text = tournament.TournamentName,
                    Value = tournament.TournamentName,
                });

            }
            vm.TournamentName = entryId.TournamentName;

            foreach (var grandPrix in listOfGrandPrixs)
            {
                vm.GrandPrixs.Add(new SelectListItem()
                {
                    Text = grandPrix.Name,
                    Value = grandPrix.Name
                });

            }
            vm.GrandPrixName = entryId.GrandPrixName;

            foreach (var driver in listOfDrivers)
            {
                vm.Drivers.Add(new SelectListItem()
                {
                    Text = driver.Name,
                    Value = driver.Name
                });

            }
            vm.Driver = entryId.Driver;
            vm.Position = entryId.Position;
            vm.Points = entryId.Points;

            return View(vm);
        }

        // POST: Races/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RaceViewModel vm)
        {
            var model = Mapper.Map<Race>(vm);

            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Races/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Race race = db.Races.Find(id);
            if (race == null)
            {
                return HttpNotFound();
            }
            return View(race);
        }

        // POST: Races/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Race race = db.Races.Find(id);
            db.Races.Remove(race);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
