using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Garble.Models;

namespace Garble.Controllers
{
    public class PastTransactionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PastTransactions
        public ActionResult Index()
        {
            return View(db.PastTransactions.ToList());
        }

        // GET: PastTransactions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PastTransaction pastTransaction = db.PastTransactions.Find(id);
            if (pastTransaction == null)
            {
                return HttpNotFound();
            }
            return View(pastTransaction);
        }

        // GET: PastTransactions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PastTransactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PastTransactionID,PickupPrice,IsPaid")] PastTransaction pastTransaction)
        {
            if (ModelState.IsValid)
            {
                db.PastTransactions.Add(pastTransaction);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pastTransaction);
        }

        // GET: PastTransactions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PastTransaction pastTransaction = db.PastTransactions.Find(id);
            if (pastTransaction == null)
            {
                return HttpNotFound();
            }
            return View(pastTransaction);
        }

        // POST: PastTransactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PastTransactionID,PickupPrice,IsPaid")] PastTransaction pastTransaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pastTransaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pastTransaction);
        }

        // GET: PastTransactions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PastTransaction pastTransaction = db.PastTransactions.Find(id);
            if (pastTransaction == null)
            {
                return HttpNotFound();
            }
            return View(pastTransaction);
        }

        // POST: PastTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PastTransaction pastTransaction = db.PastTransactions.Find(id);
            db.PastTransactions.Remove(pastTransaction);
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
