using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
    public class TournamentsController : Controller
    {
        private MarioKartWebContext db = new MarioKartWebContext();

        // GET: Tournaments
        public ActionResult Index()
        {
            List<TournamentViewModel> vms = new List<TournamentViewModel>();
            var tournaments = db.Tournaments.OrderBy(x => x.ID);

            foreach (var tournament in tournaments)
            {
                TournamentViewModel vm = new TournamentViewModel();
                vm.ID = tournament.ID;
                vm.RaceDate = DateTime.Parse(tournament.RaceDate.ToString());
                vm.TournamentName = tournament.TournamentName;
                vm.Winer = tournament.Winer;
                vm.Points = tournament.Points;
                vms.Add(vm);
            }

            return View(vms);
        }

        // GET: Tournaments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);
        }

        // GET: Tournaments/Create
        public ActionResult Create()
        {
            TournamentViewModel vm = new TournamentViewModel();

            var listOfDrivers = db.Drivers.OrderBy(x => x.Name).ToList();

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

        // POST: Tournaments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TournamentViewModel vm)
        {
            var model = Mapper.Map<Tournament>(vm);

            if (ModelState.IsValid)
            {
                db.Tournaments.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        // GET: Tournaments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entryId = db.Tournaments.FirstOrDefault(x => x.ID == id);
            if (entryId == null)
            {
                return HttpNotFound();
            }
            TournamentViewModel vm = new TournamentViewModel();

            var listOfDrivers = db.Drivers.OrderBy(x => x.Name).ToList();

            vm.RaceDate = DateTime.Parse(entryId.RaceDate.ToString());

            foreach (var driver in listOfDrivers)
            {
                vm.Drivers.Add(new SelectListItem()
                {
                    Text = driver.Name,
                    Value = driver.Name
                });

            }
            vm.TournamentName = entryId.TournamentName;
            vm.Winer = entryId.Winer;
            vm.Points = entryId.Points;

            return View(vm);
        }

        // POST: Tournaments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TournamentViewModel vm)
        {
            var model = Mapper.Map<Tournament>(vm);

            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Tournaments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tournament tournament = db.Tournaments.Find(id);
            if (tournament == null)
            {
                return HttpNotFound();
            }
            return View(tournament);
        }

        // POST: Tournaments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tournament tournament = db.Tournaments.Find(id);
            db.Tournaments.Remove(tournament);
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
