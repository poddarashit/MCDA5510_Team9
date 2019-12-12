using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrainReserveSystem.Models;

namespace TrainReserveSystem.Controllers
{
    public class Passenger_DetailsController : Controller
    {
        private Model2 db = new Model2();

        // GET: Passenger_Details
        public ActionResult Index()
        {
            return View(db.Passenger_Details.ToList());
        }

        // GET: Passenger_Details/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
            if (passenger_Details == null)
            {
                return HttpNotFound();
            }
            return View(passenger_Details);
        }

        // GET: Passenger_Details/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Passenger_Details/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FName,LName,Age,P_Address,Mobile,Email")] Passenger_Details passenger_Details)
        {
            if (ModelState.IsValid)
            {
                db.Passenger_Details.Add(passenger_Details);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(passenger_Details);
        }

        // GET: Passenger_Details/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
            if (passenger_Details == null)
            {
                return HttpNotFound();
            }
            return View(passenger_Details);
        }

        // POST: Passenger_Details/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FName,LName,Age,P_Address,Mobile,Email")] Passenger_Details passenger_Details)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenger_Details).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(passenger_Details);
        }

        // GET: Passenger_Details/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
            if (passenger_Details == null)
            {
                return HttpNotFound();
            }
            return View(passenger_Details);
        }

        // POST: Passenger_Details/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passenger_Details passenger_Details = db.Passenger_Details.Find(id);
            db.Passenger_Details.Remove(passenger_Details);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Book(int id)
        {
            Console.WriteLine("Train ID: " + id);
            return View("PassDetails");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult proceedtopayment()
        {
            return this.RedirectToAction("paymentpage", "Payments");
            
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
