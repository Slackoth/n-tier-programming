using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using premier_access_app.Models;

namespace premier_access_app.Controllers
{
    public class premierAccessController : Controller
    {
        private theaterEntities db = new theaterEntities();

        // GET: premierAccess
        public ActionResult Index()
        {
            var premier_access = db.premier_access.Include(p => p.movie).Include(p => p.person);
            return View(premier_access.ToList());
        }

        // GET: premierAccess/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            premier_access premier_access = db.premier_access.Find(id);
            if (premier_access == null)
            {
                return HttpNotFound();
            }
            return View(premier_access);
        }

        // GET: premierAccess/Create
        public ActionResult Create()
        {
            ViewBag.movie_id = new SelectList(db.movies, "id", "movie_name");
            ViewBag.person_id = new SelectList(db.people, "id", "person_name");
            return View();
        }

        // POST: premierAccess/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,movie_id,person_id")] premier_access premier_access)
        {
            if (ModelState.IsValid)
            {
                db.premier_access.Add(premier_access);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.movie_id = new SelectList(db.movies, "id", "movie_name", premier_access.movie_id);
            ViewBag.person_id = new SelectList(db.people, "id", "person_name", premier_access.person_id);
            return View(premier_access);
        }

        // GET: premierAccess/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            premier_access premier_access = db.premier_access.Find(id);
            if (premier_access == null)
            {
                return HttpNotFound();
            }
            ViewBag.movie_id = new SelectList(db.movies, "id", "movie_name", premier_access.movie_id);
            ViewBag.person_id = new SelectList(db.people, "id", "person_name", premier_access.person_id);
            return View(premier_access);
        }

        // POST: premierAccess/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,movie_id,person_id")] premier_access premier_access)
        {
            if (ModelState.IsValid)
            {
                db.Entry(premier_access).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.movie_id = new SelectList(db.movies, "id", "movie_name", premier_access.movie_id);
            ViewBag.person_id = new SelectList(db.people, "id", "person_name", premier_access.person_id);
            return View(premier_access);
        }

        // GET: premierAccess/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            premier_access premier_access = db.premier_access.Find(id);
            if (premier_access == null)
            {
                return HttpNotFound();
            }
            return View(premier_access);
        }

        // POST: premierAccess/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            premier_access premier_access = db.premier_access.Find(id);
            db.premier_access.Remove(premier_access);
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
