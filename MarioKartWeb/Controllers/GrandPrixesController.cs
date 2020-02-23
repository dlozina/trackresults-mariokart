using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MarioKartWeb.Data;
using MarioKartWeb.Models;

namespace MarioKartWeb.Controllers
{
    public class GrandPrixesController : Controller
    {
        private MarioKartWebContext db = new MarioKartWebContext();

        // GET: GrandPrixes
        public ActionResult Index()
        {
            return View(db.GrandPrixes.ToList());
        }

        // GET: GrandPrixes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrandPrix grandPrix = db.GrandPrixes.Find(id);
            if (grandPrix == null)
            {
                return HttpNotFound();
            }
            return View(grandPrix);
        }

        // GET: GrandPrixes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GrandPrixes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name")] GrandPrix grandPrix)
        {
            if (ModelState.IsValid)
            {
                db.GrandPrixes.Add(grandPrix);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grandPrix);
        }

        // GET: GrandPrixes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrandPrix grandPrix = db.GrandPrixes.Find(id);
            if (grandPrix == null)
            {
                return HttpNotFound();
            }
            return View(grandPrix);
        }

        // POST: GrandPrixes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name")] GrandPrix grandPrix)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grandPrix).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grandPrix);
        }

        // GET: GrandPrixes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GrandPrix grandPrix = db.GrandPrixes.Find(id);
            if (grandPrix == null)
            {
                return HttpNotFound();
            }
            return View(grandPrix);
        }

        // POST: GrandPrixes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GrandPrix grandPrix = db.GrandPrixes.Find(id);
            db.GrandPrixes.Remove(grandPrix);
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
