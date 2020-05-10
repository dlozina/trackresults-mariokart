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
    [Authorize]
    public class GrandPrixesController : Controller
    {
        private readonly IRaces racesService;
        public GrandPrixesController(IRaces racesService)
        {
            this.racesService = racesService;
        }

        // GET: GrandPrixes
        public ActionResult Index()
        {
            List<GrandPrixViewModel> vms = new List<GrandPrixViewModel>();
            var grandPrixes = racesService.GetGrandPrixes().OrderByDescending(x => x.ID);

            foreach(var grandPrix in grandPrixes)
            {
                GrandPrixViewModel vm = new GrandPrixViewModel();
                vm.ID = grandPrix.ID;
                vm.Name = grandPrix.Name;
                vms.Add(vm);
            }

            return View(vms);
        }

        // GET: GrandPrixes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var grandPrix = racesService.GetGrandPrixes().Find(id);
            if (grandPrix == null)
            {
                return HttpNotFound();
            }
            GrandPrixViewModel vm = new GrandPrixViewModel();
            vm = Mapper.Map<GrandPrixViewModel>(grandPrix);
            return View(vm);
        }

        // GET: GrandPrixes/Create
        public ActionResult Create()
        {
            GrandPrixViewModel vm = new GrandPrixViewModel();
            return View(vm);
        }

        // POST: GrandPrixes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GrandPrixViewModel vm)
        {
            var model = Mapper.Map<GrandPrix>(vm);

            if (ModelState.IsValid)
            {
                racesService.SaveNewGrandPrix(model);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: GrandPrixes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var grandPrix = racesService.GetGrandPrixes().Find(id);
            if (grandPrix == null)
            {
                return HttpNotFound();
            }

            GrandPrixViewModel vm = new GrandPrixViewModel();
            vm.Name = grandPrix.Name;

            return View(vm);
        }

        // POST: GrandPrixes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GrandPrixViewModel vm)
        {
            var model = Mapper.Map<GrandPrix>(vm);

            if (ModelState.IsValid)
            {
                racesService.EditGrandPrix(model);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: GrandPrixes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var grandPrix = racesService.GetGrandPrixes().Find(id);
            GrandPrixViewModel vm = new GrandPrixViewModel();
            vm = Mapper.Map<GrandPrixViewModel>(grandPrix);
            if (grandPrix == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

        // POST: GrandPrixes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var grandPrix = racesService.GetGrandPrixes().Find(id);
            racesService.DeleteGrandPrix(grandPrix);
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
