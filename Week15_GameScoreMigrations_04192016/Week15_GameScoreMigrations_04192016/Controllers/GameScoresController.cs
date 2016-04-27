using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week15_GameScoreMigrations_04192016.Models;

namespace Week15_GameScoreMigrations_04192016.Controllers
{
    public class GameScoresController : Controller
    {
        private Week15_GameScoreMigrations_04192016Context db = new Week15_GameScoreMigrations_04192016Context();

        // GET: GameScores
        public ActionResult Index()
        {
            return View(db.GameScores.ToList());
        }

        // GET: GameScores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameScore gameScore = db.GameScores.Find(id);
            if (gameScore == null)
            {
                return HttpNotFound();
            }
            return View(gameScore);
        }

        // GET: GameScores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameScores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Points")] GameScore gameScore)
        {
            if (ModelState.IsValid)
            {
                db.GameScores.Add(gameScore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameScore);
        }

        // GET: GameScores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameScore gameScore = db.GameScores.Find(id);
            if (gameScore == null)
            {
                return HttpNotFound();
            }
            return View(gameScore);
        }

        // POST: GameScores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Points")] GameScore gameScore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameScore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameScore);
        }

        // GET: GameScores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameScore gameScore = db.GameScores.Find(id);
            if (gameScore == null)
            {
                return HttpNotFound();
            }
            return View(gameScore);
        }

        // POST: GameScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameScore gameScore = db.GameScores.Find(id);
            db.GameScores.Remove(gameScore);
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
