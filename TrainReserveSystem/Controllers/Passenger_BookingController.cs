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
    public class Passenger_BookingController : Controller
    {
        private Model2 db = new Model2();

        // GET: Passenger_Booking
        public ActionResult Index()
        {
            var passenger_Booking = db.Passenger_Booking.Include(p => p.Booking).Include(p => p.Passenger_Details);
            return View(passenger_Booking.ToList());
        }

        // GET: Passenger_Booking/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Booking passenger_Booking = db.Passenger_Booking.Find(id);
            if (passenger_Booking == null)
            {
                return HttpNotFound();
            }
            return View(passenger_Booking);
        }

        // GET: Passenger_Booking/Create
        public ActionResult Create()
        {
            ViewBag.FK_Booking_ID = new SelectList(db.Bookings, "Booking_ID", "Booking_ID");
            ViewBag.FK_ID = new SelectList(db.Passenger_Details, "ID", "FName");
            return View();
        }

        // POST: Passenger_Booking/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PB_ID,FK_Booking_ID,FK_ID")] Passenger_Booking passenger_Booking)
        {
            if (ModelState.IsValid)
            {
                db.Passenger_Booking.Add(passenger_Booking);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FK_Booking_ID = new SelectList(db.Bookings, "Booking_ID", "Booking_ID", passenger_Booking.FK_Booking_ID);
            ViewBag.FK_ID = new SelectList(db.Passenger_Details, "ID", "FName", passenger_Booking.FK_ID);
            return View(passenger_Booking);
        }

        // GET: Passenger_Booking/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Booking passenger_Booking = db.Passenger_Booking.Find(id);
            if (passenger_Booking == null)
            {
                return HttpNotFound();
            }
            ViewBag.FK_Booking_ID = new SelectList(db.Bookings, "Booking_ID", "Booking_ID", passenger_Booking.FK_Booking_ID);
            ViewBag.FK_ID = new SelectList(db.Passenger_Details, "ID", "FName", passenger_Booking.FK_ID);
            return View(passenger_Booking);
        }

        // POST: Passenger_Booking/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PB_ID,FK_Booking_ID,FK_ID")] Passenger_Booking passenger_Booking)
        {
            if (ModelState.IsValid)
            {
                db.Entry(passenger_Booking).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FK_Booking_ID = new SelectList(db.Bookings, "Booking_ID", "Booking_ID", passenger_Booking.FK_Booking_ID);
            ViewBag.FK_ID = new SelectList(db.Passenger_Details, "ID", "FName", passenger_Booking.FK_ID);
            return View(passenger_Booking);
        }

        // GET: Passenger_Booking/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Passenger_Booking passenger_Booking = db.Passenger_Booking.Find(id);
            if (passenger_Booking == null)
            {
                return HttpNotFound();
            }
            return View(passenger_Booking);
        }

        // POST: Passenger_Booking/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Passenger_Booking passenger_Booking = db.Passenger_Booking.Find(id);
            db.Passenger_Booking.Remove(passenger_Booking);
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
