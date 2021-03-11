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
    public class BookStoresController : Controller
    {
        private BookStoreDBContext db = new BookStoreDBContext();

        // GET: BookStores
        public ActionResult Index()
        {
            return View(db.BookStore.ToList());
        }

        // GET: BookStores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookStore bookStore = db.BookStore.Find(id);
            if (bookStore == null)
            {
                return HttpNotFound();
            }
            return View(bookStore);
        }

        // GET: BookStores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookStores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Author,Pubisher,ISBN,Description,PublishedDate,Genre,Price")] BookStore bookStore)
        {
            if (ModelState.IsValid)
            {
                db.BookStore.Add(bookStore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookStore);
        }

        // GET: BookStores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookStore bookStore = db.BookStore.Find(id);
            if (bookStore == null)
            {
                return HttpNotFound();
            }
            return View(bookStore);
        }

        // POST: BookStores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Author,Pubisher,ISBN,Description,PublishedDate,Genre,Price")] BookStore bookStore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookStore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookStore);
        }

        // GET: BookStores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookStore bookStore = db.BookStore.Find(id);
            if (bookStore == null)
            {
                return HttpNotFound();
            }
            return View(bookStore);
        }

        // POST: BookStores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookStore bookStore = db.BookStore.Find(id);
            db.BookStore.Remove(bookStore);
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
