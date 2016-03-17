using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoalsWebsite.DbContexts;
using GoalsWebsite.Entities;

namespace GoalsWebsite.Controllers
{
    public class PersonalDetailsController : Controller
    {
        private WebsiteContext db = new WebsiteContext();

        // GET: PersonalDetails
        public ActionResult Index()
        {
            return View(db.Details.ToList());
        }

        // GET: PersonalDetails/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetails personalDetails = db.Details.Find(id);
            if (personalDetails == null)
            {
                return HttpNotFound();
            }
            return View(personalDetails);
        }

        // GET: PersonalDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonalDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,FirstName,LastName,Adres")] PersonalDetails personalDetails)
        {
            if (ModelState.IsValid)
            {
                personalDetails.id = Guid.NewGuid();
                db.Details.Add(personalDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personalDetails);
        }

        // GET: PersonalDetails/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetails personalDetails = db.Details.Find(id);
            if (personalDetails == null)
            {
                return HttpNotFound();
            }
            return View(personalDetails);
        }

        // POST: PersonalDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,FirstName,LastName,Adres")] PersonalDetails personalDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personalDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personalDetails);
        }

        // GET: PersonalDetails/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PersonalDetails personalDetails = db.Details.Find(id);
            if (personalDetails == null)
            {
                return HttpNotFound();
            }
            return View(personalDetails);
        }

        // POST: PersonalDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            PersonalDetails personalDetails = db.Details.Find(id);
            db.Details.Remove(personalDetails);
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
