using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week15_MVCProjectTestSite_04182016.Models;

namespace Week15_MVCProjectTestSite_04182016.Controllers
{
    public class ChildTopsController : Controller
    {
        private Week15_MVCProjectTestSite_04182016Context db = new Week15_MVCProjectTestSite_04182016Context();

        // GET: ChildTops
        public ActionResult Index()
        {
            return View(db.ChildTops.ToList());
        }

        // GET: ChildTops/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChildTop childTop = db.ChildTops.Find(id);
            if (childTop == null)
            {
                return HttpNotFound();
            }
            return View(childTop);
        }

        // GET: ChildTops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChildTops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopID,Item,Nickname,Season")] ChildTop childTop)
        {
            if (ModelState.IsValid)
            {
                db.ChildTops.Add(childTop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(childTop);
        }

        // GET: ChildTops/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChildTop childTop = db.ChildTops.Find(id);
            if (childTop == null)
            {
                return HttpNotFound();
            }
            return View(childTop);
        }

        // POST: ChildTops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopID,Item,Nickname,Season")] ChildTop childTop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(childTop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(childTop);
        }

        // GET: ChildTops/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChildTop childTop = db.ChildTops.Find(id);
            if (childTop == null)
            {
                return HttpNotFound();
            }
            return View(childTop);
        }

        // POST: ChildTops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ChildTop childTop = db.ChildTops.Find(id);
            db.ChildTops.Remove(childTop);
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
