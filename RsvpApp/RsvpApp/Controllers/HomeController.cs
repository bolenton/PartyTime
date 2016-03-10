using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RsvpApp.Models;

namespace RsvpApp.Controllers
{
    public class HomeController : Controller
    {
        private RsvpAppContext db = new RsvpAppContext();

        // GEt: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Super: to manage guests
        public ActionResult Super()
        {
            return View(db.GuestResponses.ToList());
        }

        [HttpPost]
        public ViewResult Rsvp(GuestResponse guestResponse)
        {
            var firstName = guestResponse.FirstName;
            var lastName = guestResponse.LastName;
            var phone = guestResponse.PhoneNumber;
            var adult = guestResponse.Adults;
            var arrival = guestResponse.Arrival;
            var departure = guestResponse.Departure;
            var email = guestResponse.EmailAddress;
            var attending = guestResponse.WillAttend;
            var info = guestResponse.Information;

            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        //
        //
        // Default Views by entity
        //
        //
        // GET: Home/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestResponse guestResponse = db.GuestResponses.Find(id);
            if (guestResponse == null)
            {
                return HttpNotFound();
            }
            return View(guestResponse);
        }

        // GET: Home/Create
        public ActionResult Rsvp()
        {
            return View();
        }

        // POST: Home/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Rsvp([Bind(Include = "Id,FirstName,LastName,PhoneNumber,EmailAddress,WillAttend,Adults,Arrival,Departure,Information")] GuestResponse guestResponse)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.GuestResponses.Add(guestResponse);
        //        db.SaveChanges();
        //        return RedirectToAction("Thanks", guestResponse);
        //    }

        //    return View(guestResponse);
        //}

        // GET: Home/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestResponse guestResponse = db.GuestResponses.Find(id);
            if (guestResponse == null)
            {
                return HttpNotFound();
            }
            return View(guestResponse);
        }

        // POST: Home/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,PhoneNumber,EmailAddress,WillAttend,Adults,Arrival,Departure,Information")] GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guestResponse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Super");
            }
            return View(guestResponse);
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestResponse guestResponse = db.GuestResponses.Find(id);
            if (guestResponse == null)
            {
                return HttpNotFound();
            }
            return View(guestResponse);
        }

        // POST: Home/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GuestResponse guestResponse = db.GuestResponses.Find(id);
            db.GuestResponses.Remove(guestResponse);
            db.SaveChanges();
            return RedirectToAction("Super");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Thanks()
        {
            return Thanks();
        }
    }
}
