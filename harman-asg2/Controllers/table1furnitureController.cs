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
{[Authorize]
    public class table1furnitureController : Controller
    {
        private Model1 db = new Model1();
        [AllowAnonymous]
        // GET: table1furniture
        public ActionResult Index()
        {
            return View(db.table1furniture.ToList());
        }
        [AllowAnonymous]
        // GET: table1furniture/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table1furniture table1furniture = db.table1furniture.Find(id);
            if (table1furniture == null)
            {
                return HttpNotFound();
            }
            return View(table1furniture);
        }

        // GET: table1furniture/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: table1furniture/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,Brand,Price,RoomColor")] table1furniture table1furniture)
        {
            if (ModelState.IsValid)
            {
                db.table1furniture.Add(table1furniture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table1furniture);
        }

        // GET: table1furniture/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table1furniture table1furniture = db.table1furniture.Find(id);
            if (table1furniture == null)
            {
                return HttpNotFound();
            }
            return View(table1furniture);
        }

        // POST: table1furniture/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,Brand,Price,RoomColor")] table1furniture table1furniture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table1furniture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table1furniture);
        }

        // GET: table1furniture/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            table1furniture table1furniture = db.table1furniture.Find(id);
            if (table1furniture == null)
            {
                return HttpNotFound();
            }
            return View(table1furniture);
        }

        // POST: table1furniture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            table1furniture table1furniture = db.table1furniture.Find(id);
            db.table1furniture.Remove(table1furniture);
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
