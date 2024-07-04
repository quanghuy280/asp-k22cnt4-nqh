using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace NqhK22CNTLesson11.Controllers
{
    public class NqhCategoriesController : Controller
    {
        private NqhK22CNTLesson11Entities db = new NqhK22CNTLesson11Entities();

        // GET: NqhCategories
        public ActionResult NqhIndex()
        {
            return View(db.NqhCategories.ToList());
        }

        // GET: NqhCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhCategory nqhCategory = db.NqhCategories.Find(id);
            if (nqhCategory == null)
            {
                return HttpNotFound();
            }
            return View(nqhCategory);
        }

        // GET: NqhCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NqhCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NqhID,NqhCateName,NqhStatus")] NqhCategory nqhCategory)
        {
            if (ModelState.IsValid)
            {
                db.NqhCategories.Add(nqhCategory);
                db.SaveChanges();
                return RedirectToAction("NqhIndex");
            }

            return View(nqhCategory);
        }

        // GET: NqhCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhCategory nqhCategory = db.NqhCategories.Find(id);
            if (nqhCategory == null)
            {
                return HttpNotFound();
            }
            return View(nqhCategory);
        }

        // POST: NqhCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NqhID,NqhCateName,NqhStatus")] NqhCategory nqhCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nqhCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NqhIndex");
            }
            return View(nqhCategory);
        }

        // GET: NqhCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhCategory nqhCategory = db.NqhCategories.Find(id);
            if (nqhCategory == null)
            {
                return HttpNotFound();
            }
            return View(nqhCategory);
        }

        // POST: NqhCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NqhCategory nqhCategory = db.NqhCategories.Find(id);
            db.NqhCategories.Remove(nqhCategory);
            db.SaveChanges();
            return RedirectToAction("NqhIndex");
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
