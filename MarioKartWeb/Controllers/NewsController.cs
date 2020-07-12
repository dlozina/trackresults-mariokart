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
using MarioKart.Model;
using MarioKartService.ApplicationServices.Interfaces;
using MarioKartWeb.Models;
using MarioKartWeb.ViewModel;

namespace MarioKartWeb.Controllers
{
    public class NewsController : Controller
    {
        private readonly IAppInformations appInformationsService;

        public NewsController(IAppInformations appInformationsService)
        {
            this.appInformationsService = appInformationsService;
        }

        // GET: News
        public ActionResult Index()
        {
            List<NewsViewModel> vms = new List<NewsViewModel>();
            var Newss = appInformationsService.GetNews().OrderByDescending(x => x.ID);

            foreach (var News in Newss)
            {
                NewsViewModel vm = new NewsViewModel();
                vm.ID = News.ID;
                vm.DateEntered = DateTime.Parse(News.DateEntered.ToString());
                vm.NewsTitle = News.NewsTitle;
                vm.NewsStory = News.NewsStory;
                vms.Add(vm);
            }

            return View(vms);
        }

        // GET: News/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var news = appInformationsService.GetNews().Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }
            NewsViewModel vm = new NewsViewModel();
            vm = Mapper.Map<NewsViewModel>(news);
            return View(vm);
        }

        // GET: News/Create
        public ActionResult Create()
        {
            NewsViewModel vm = new NewsViewModel();
            string dateTimeNow = DateTime.Now.ToString("dd/MMMM/yyyy");
            DateTime date = DateTime.ParseExact(dateTimeNow, "dd/MMMM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);

            vm.DateEntered = DateTime.Parse(date.ToString());
            return View(vm);
        }

        // POST: News/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(NewsViewModel vm)
        {
            var model = Mapper.Map<News>(vm);
            if (ModelState.IsValid)
            {
                appInformationsService.SaveNewNews(model);
                return RedirectToAction("Index");
            }

            return View(vm);
        }

        // GET: News/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var news = appInformationsService.GetNews().Find(id);
            if (news == null)
            {
                return HttpNotFound();
            }

            NewsViewModel vm = new NewsViewModel();

            vm.DateEntered = DateTime.Parse(news.DateEntered.ToString());
            vm.NewsTitle = news.NewsTitle;
            vm.NewsStory = news.NewsStory;

            return View(vm);
        }

        // POST: News/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(NewsViewModel vm)
        {
            var model = Mapper.Map<News>(vm);
            if (ModelState.IsValid)
            {
                appInformationsService.EditNews(model);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        // GET: News/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var news = appInformationsService.GetNews().Find(id);
            NewsViewModel vm = new NewsViewModel();
            vm = Mapper.Map<NewsViewModel>(news);
            if (news == null)
            {
                return HttpNotFound();
            }
            return View(vm);
        }

        // POST: News/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var news = appInformationsService.GetNews().Find(id);
            appInformationsService.DeleteNews(news);
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
