using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NqhBaiKiemTraGK.Models;

namespace NqhBaiKiemTraGK.Controllers
{
    public class NqhKhoasController : Controller
    {
        private NqhK22CNT4Lesson07PREntities db = new NqhK22CNT4Lesson07PREntities();

        // GET: NqhKhoas
        public ActionResult NqhIndex()
        {
            return View(db.NqhKhoa.ToList());
        }

        // GET: NqhKhoas/Details/5
        public ActionResult NqhDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhKhoa nqhKhoa = db.NqhKhoa.Find(id);
            if (nqhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nqhKhoa);
        }

        // GET: NqhKhoas/Create
        public ActionResult NqhCreate()
        {
            return View();
        }

        // POST: NqhKhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NqhCreate([Bind(Include = "NqhMaKH,NqhTenKH,NqhTrangThai")] NqhKhoa nqhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.NqhKhoa.Add(nqhKhoa);
                db.SaveChanges();
                return RedirectToAction("NqhIndex");
            }

            return View(nqhKhoa);
        }

        // GET: NqhKhoas/Edit/5
        public ActionResult NqhEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhKhoa nqhKhoa = db.NqhKhoa.Find(id);
            if (nqhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nqhKhoa);
        }

        // POST: NqhKhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NqhEdit([Bind(Include = "NqhMaKH,NqhTenKH,NqhTrangThai")] NqhKhoa nqhKhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nqhKhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NqhIndex");
            }
            return View(nqhKhoa);
        }

        // GET: NqhKhoas/Delete/5
        public ActionResult NqhDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhKhoa nqhKhoa = db.NqhKhoa.Find(id);
            if (nqhKhoa == null)
            {
                return HttpNotFound();
            }
            return View(nqhKhoa);
        }

        // POST: NqhKhoas/Delete/5
        [HttpPost, ActionName("NqhDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NqhKhoa nqhKhoa = db.NqhKhoa.Find(id);
            db.NqhKhoa.Remove(nqhKhoa);
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
