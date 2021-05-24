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
    public class rolesController : Controller
    {
        private theaterEntities db = new theaterEntities();

        // GET: roles
        public ActionResult Index()
        {
            return View(db.person_role.ToList());
        }

        // GET: roles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person_role person_role = db.person_role.Find(id);
            if (person_role == null)
            {
                return HttpNotFound();
            }
            return View(person_role);
        }

        // GET: roles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: roles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,role_name,role_description,role_state")] person_role person_role)
        {
            if (ModelState.IsValid)
            {
                db.person_role.Add(person_role);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(person_role);
        }

        // GET: roles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person_role person_role = db.person_role.Find(id);
            if (person_role == null)
            {
                return HttpNotFound();
            }
            return View(person_role);
        }

        // POST: roles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,role_name,role_description,role_state")] person_role person_role)
        {
            if (ModelState.IsValid)
            {
                db.Entry(person_role).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(person_role);
        }

        // GET: roles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            person_role person_role = db.person_role.Find(id);
            if (person_role == null)
            {
                return HttpNotFound();
            }
            return View(person_role);
        }

        // POST: roles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            person_role person_role = db.person_role.Find(id);
            db.person_role.Remove(person_role);
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
