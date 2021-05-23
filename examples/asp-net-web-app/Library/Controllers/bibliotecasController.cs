using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class bibliotecasController : Controller
    {
        private bibliotecaEntities db = new bibliotecaEntities();

        // GET: bibliotecas
        public ActionResult Index()
        {
            var bibliotecas = db.bibliotecas.Include(b => b.libro).Include(b => b.usuario);
            return View(bibliotecas.ToList());
        }

        // GET: bibliotecas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            biblioteca biblioteca = db.bibliotecas.Find(id);
            if (biblioteca == null)
            {
                return HttpNotFound();
            }
            return View(biblioteca);
        }

        // GET: bibliotecas/Create
        public ActionResult Create()
        {
            ViewBag.idlibro = new SelectList(db.libroes, "idlibro", "nombre");
            ViewBag.nombre_usuario = new SelectList(db.usuarios, "nombre", "contrasena");
            return View();
        }

        // POST: bibliotecas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idbiblioteca,nombre_usuario,idlibro")] biblioteca biblioteca)
        {
            if (ModelState.IsValid)
            {
                db.bibliotecas.Add(biblioteca);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idlibro = new SelectList(db.libroes, "idlibro", "nombre", biblioteca.idlibro);
            ViewBag.nombre_usuario = new SelectList(db.usuarios, "nombre", "contrasena", biblioteca.nombre_usuario);
            return View(biblioteca);
        }

        // GET: bibliotecas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            biblioteca biblioteca = db.bibliotecas.Find(id);
            if (biblioteca == null)
            {
                return HttpNotFound();
            }
            ViewBag.idlibro = new SelectList(db.libroes, "idlibro", "nombre", biblioteca.idlibro);
            ViewBag.nombre_usuario = new SelectList(db.usuarios, "nombre", "contrasena", biblioteca.nombre_usuario);
            return View(biblioteca);
        }

        // POST: bibliotecas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idbiblioteca,nombre_usuario,idlibro")] biblioteca biblioteca)
        {
            if (ModelState.IsValid)
            {
                db.Entry(biblioteca).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idlibro = new SelectList(db.libroes, "idlibro", "nombre", biblioteca.idlibro);
            ViewBag.nombre_usuario = new SelectList(db.usuarios, "nombre", "contrasena", biblioteca.nombre_usuario);
            return View(biblioteca);
        }

        // GET: bibliotecas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            biblioteca biblioteca = db.bibliotecas.Find(id);
            if (biblioteca == null)
            {
                return HttpNotFound();
            }
            return View(biblioteca);
        }

        // POST: bibliotecas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            biblioteca biblioteca = db.bibliotecas.Find(id);
            db.bibliotecas.Remove(biblioteca);
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
