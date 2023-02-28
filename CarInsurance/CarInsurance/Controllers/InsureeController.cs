using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                Quote(insuree.Id);
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        // calculates quote

        public ActionResult Quote(int? id)
        {

            Insuree insuree = db.Insurees.Find(id);
            // base is $50
            decimal baseQuote = 50.00M;
            // calculating age based on year
            int currentAge = DateTime.Now.Year - insuree.DateOfBirth.Year;
            decimal ageBase = 0.00M;
            // conditions to determine what the age base is depending on driver's current age
            if (currentAge < 19) { ageBase += 100.00M; }
            else if (currentAge >= 19 && currentAge < 26) { ageBase += 50.00M; }
            else if (currentAge >= 26) { ageBase += 25.00M; }
            // determining what to add based on car's age
            decimal carBase = 0.00M;
            if (insuree.CarYear < 2000 || insuree.CarYear > 2015) { carBase += 25.00M; }
            // determining if quote increases based on car make
            decimal makeBase = 0.00M;
            if (insuree.CarMake == "Porsche" || insuree.CarMake == "porsche")
            {
                makeBase += 25.00M;
                if (insuree.CarMake == "911 Carrera" || insuree.CarMake == "911 carrera") { makeBase += 50.00M; }
            }
            // determines if we need to add for speeding tickets
            decimal speedingBase = insuree.SpeedingTickets * 10.00M;
            // determines if we need to add for DUIs
            decimal duiBase = 0.00M;
            if (Convert.ToBoolean(insuree.DUI)) { duiBase = (baseQuote + ageBase + carBase + makeBase + speedingBase) * 1.25M; }
            // calculating for full coverage
            decimal fullBase = 0.00M;
            if (Convert.ToBoolean(insuree.CoverageType)) { fullBase = (baseQuote + ageBase + carBase + makeBase + speedingBase + duiBase) * 1.5M; }
            // total calculation adds all base quotes
            decimal totalQuote = baseQuote + ageBase + carBase + makeBase + speedingBase + duiBase + fullBase;
            insuree.Quote = totalQuote;
            db.SaveChanges();
            return null; // placeholder
        }

        public ActionResult Admin() { return View(db.Insurees.ToList()); }
    }
}
