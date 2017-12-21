using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using harman_asg2.Models;

namespace harman_asg2.Controllers
{
    public class table2furnitureController : Controller
    {
        private Model1 db = new Model1();

        // GET: table2furniture
        public ActionResult Index()
        {
            return View(db.table2furniture.ToList());
        }

        // GET: table2furniture/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table2furniture table2furniture = db.table2furniture.Find(id);
            if (table2furniture == null)
            {
                return HttpNotFound();
            }
            return View(table2furniture);
        }

        // GET: table2furniture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: table2furniture/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Brand,CustomerID,Furniture_type,FloorTiles")] table2furniture table2furniture)
        {
            if (ModelState.IsValid)
            {
                db.table2furniture.Add(table2furniture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table2furniture);
        }

        // GET: table2furniture/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table2furniture table2furniture = db.table2furniture.Find(id);
            if (table2furniture == null)
            {
                return HttpNotFound();
            }
            return View(table2furniture);
        }

        // POST: table2furniture/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Brand,CustomerID,Furniture_type,FloorTiles")] table2furniture table2furniture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table2furniture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table2furniture);
        }

        // GET: table2furniture/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table2furniture table2furniture = db.table2furniture.Find(id);
            if (table2furniture == null)
            {
                return HttpNotFound();
            }
            return View(table2furniture);
        }

        // POST: table2furniture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            table2furniture table2furniture = db.table2furniture.Find(id);
            db.table2furniture.Remove(table2furniture);
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
