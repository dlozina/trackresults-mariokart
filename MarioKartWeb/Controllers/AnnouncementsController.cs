using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarioKart.Model;
using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.Models;
using MarioKartWeb.ViewModel;
using AutoMapper;
using System.Globalization;

namespace MarioKartWeb.Controllers
{
    public class AnnouncementsController : Controller
    {
        private readonly IAppInformations appInformationsService;

        public AnnouncementsController(IAppInformations appInformationsService)
        {
            this.appInformationsService = appInformationsService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<AnnouncementViewModel> vms = new List<AnnouncementViewModel>();
            var announcements = appInformationsService.GetAnnouncements().OrderByDescending(x => x.ID);

            foreach(var announcement in announcements)
            {
                AnnouncementViewModel vm = new AnnouncementViewModel();
                vm.ID = announcement.ID;
                vm.DateEntered = DateTime.Parse(announcement.DateEntered.ToString());
                vm.Title = announcement.Title;
                vm.TournamentName = announcement.TournamentName;
                vm.TournamentDate = DateTime.Parse(announcement.TournamentDate.ToString());
                vm.TournamentTime = DateTime.Parse(announcement.TournamentTime.ToString());
                vm.TournamentCallTime = DateTime.Parse(announcement.TournamentCallTime.ToString());
                vm.Story = announcement.Story;
                vms.Add(vm);
            }

            return View(vms);
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var announcement = appInformationsService.GetAnnouncements().Find(id);
            if (announcement == null)
            {
                return HttpNotFound();
            }
            AnnouncementViewModel vm = new AnnouncementViewModel();
            vm = Mapper.Map<AnnouncementViewModel>(announcement);
            return View(vm);
        }

        [HttpGet]
        public ActionResult Create()
        {
            AnnouncementViewModel vm = new AnnouncementViewModel();
            string dateTimeNow = DateTime.Now.ToString("dd/MMMM/yyyy");
            DateTime date = DateTime.ParseExact(dateTimeNow, "dd/MMMM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
            DateTime time = new DateTime(date.Year, date.Month, date.Day, 16, 00, 00);

            vm.DateEntered = DateTime.Parse(date.ToString());
            vm.TournamentDate = DateTime.Parse(date.ToString());
            vm.TournamentTime = DateTime.Parse(time.ToString());
            vm.TournamentCallTime = DateTime.Parse(time.ToString());
            return View(vm);
        }

        // POST: Announcements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AnnouncementViewModel vm)
        {
            var model = Mapper.Map<Announcement>(vm);
            if (ModelState.IsValid)
            {
                appInformationsService.SaveNewAnnouncement(model);
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var announcement = appInformationsService.GetAnnouncements().Find(id);
            if (announcement == null)
            {
                return HttpNotFound();
            }

            AnnouncementViewModel vm = new AnnouncementViewModel();

            vm.DateEntered = DateTime.Parse(announcement.DateEntered.ToString());
            vm.Title = announcement.Title;
            vm.TournamentName = announcement.TournamentName;
            vm.TournamentDate = DateTime.Parse(announcement.TournamentDate.ToString());
            vm.TournamentTime = DateTime.Parse(announcement.TournamentTime.ToString());
            vm.TournamentCallTime = DateTime.Parse(announcement.TournamentCallTime.ToString());
            vm.Story = announcement.Story;

            return View(vm);
        }

        // POST: Announcements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AnnouncementViewModel vm)
        {
            var model = Mapper.Map<Announcement>(vm);
            if (ModelState.IsValid)
            {
                appInformationsService.EditAnnouncement(model);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var announcement = appInformationsService.GetAnnouncements().Find(id);
            AnnouncementViewModel vm = new AnnouncementViewModel();
            vm = Mapper.Map<AnnouncementViewModel>(announcement);
            if (announcement == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var announcement = appInformationsService.GetAnnouncements().Find(id);
            appInformationsService.DeleteAnnouncement(announcement);
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
