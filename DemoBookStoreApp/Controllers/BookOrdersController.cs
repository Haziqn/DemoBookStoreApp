using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DemoBookStoreApp.Models;

namespace DemoBookStoreApp.Controllers
{
    public class BookOrdersController : Controller
    {
        private BookStoreDBContext db = new BookStoreDBContext();

        // GET: BookOrders
        public ActionResult Index()
        {
            return View(db.BookOrders.ToList());
        }

        // GET: BookOrders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookOrder bookOrder = db.BookOrders.Find(id);
            if (bookOrder == null)
            {
                return HttpNotFound();
            }
            return View(bookOrder);
        }

        // GET: BookOrders/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderId,ISBN,FirstName,LastName,Email,cardNumber,ExpirationDate,CVV,Country,State,zipCode,AddressLine")] BookOrder bookOrder)
        {
            if (ModelState.IsValid)
            {
                db.BookOrders.Add(bookOrder);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookOrder);
        }

        // GET: BookOrders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookOrder bookOrder = db.BookOrders.Find(id);
            if (bookOrder == null)
            {
                return HttpNotFound();
            }
            return View(bookOrder);
        }

        // POST: BookOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderId,ISBN,FirstName,LastName,Email,cardNumber,ExpirationDate,CVV,Country,State,zipCode,AddressLine")] BookOrder bookOrder)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookOrder).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookOrder);
        }

        // GET: BookOrders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookOrder bookOrder = db.BookOrders.Find(id);
            if (bookOrder == null)
            {
                return HttpNotFound();
            }
            return View(bookOrder);
        }

        // POST: BookOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookOrder bookOrder = db.BookOrders.Find(id);
            db.BookOrders.Remove(bookOrder);
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
