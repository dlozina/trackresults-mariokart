using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MarioKart.Model;
using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.ViewModel;

namespace MarioKartWeb.Controllers
{
    public class DriversController : Controller
    {
        private readonly IDrivers driversService;
        private readonly IRaces racesService;

        public DriversController(IDrivers driversService, IRaces racesService)
        {
            this.driversService = driversService;
            this.racesService = racesService;
        }

        // GET: Drivers
        public ActionResult Index()
        {
            List<DriverViewModel> vms = new List<DriverViewModel>();
            var drivers = driversService.GetDrivers().OrderByDescending(x => x.ID);

            foreach(var driver in drivers)
            {
                DriverViewModel vm = new DriverViewModel();
                vm.ID = driver.ID;
                vm.Name = driver.Name;
                vm.Description = driver.Description;
                vm.FavoriteTrack = driver.FavoriteTrack;
                vm.FavoriteCar = driver.FavoriteCar;
                vms.Add(vm);
            }

            return View(vms);
        }

        // GET: Drivers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var driver = driversService.GetDrivers().Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            DriverViewModel vm = new DriverViewModel();
            vm = Mapper.Map<DriverViewModel>(driver);
            return View(vm);
        }

        // GET: Drivers/Create
        public ActionResult Create()
        {
            DriverViewModel vm = new DriverViewModel();
            return View();
        }

        // POST: Drivers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DriverViewModel vm)
        {
            var model = Mapper.Map<Driver>(vm);

            if (ModelState.IsValid)
            {
                driversService.SaveNewDriver(model);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: Drivers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var driver = driversService.GetDrivers().Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            DriverViewModel vm = new DriverViewModel();
            vm.Name = driver.Name;
            vm.Description = driver.Description;
            vm.FavoriteTrack = driver.FavoriteTrack;
            vm.FavoriteCar = driver.FavoriteCar;

            return View(vm);
        }

        // POST: Drivers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DriverViewModel vm)
        {
            var model = Mapper.Map<Driver>(vm);
            if (ModelState.IsValid)
            {
                driversService.EditDriver(model);
                return RedirectToAction("Index");
            }
            // TO DO vracamo prazan VM
            return View(vm);
        }

        // GET: Drivers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var driver = driversService.GetDrivers().Find(id);
            DriverViewModel vm = new DriverViewModel();
            vm = Mapper.Map<DriverViewModel>(driver);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

        // POST: Drivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var driver = driversService.GetDrivers().Find(id);
            driversService.DeleteDriver(driver);
            return RedirectToAction("Index");
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
