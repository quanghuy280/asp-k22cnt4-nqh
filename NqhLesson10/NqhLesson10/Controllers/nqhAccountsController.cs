using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NqhLesson10.Models;

namespace NqhLesson10.Controllers
{
    public class nqhAccountsController : Controller
    {
        private NqhLesson10Entities db = new NqhLesson10Entities();

        // GET: nqhAccounts
        public ActionResult Index()
        {
            return View(db.nqhAccounts.ToList());
        }

        // GET: nqhAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhAccount nqhAccount = db.nqhAccounts.Find(id);
            if (nqhAccount == null)
            {
                return HttpNotFound();
            }
            return View(nqhAccount);
        }

        // GET: nqhAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nqhAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NqhID,NqhUserName,NqhPassWord,NqhFullName,NqhEmail,NqhPhone,NqhActive")] NqhAccount nqhAccount)
        {
            if (ModelState.IsValid)
            {
                db.nqhAccounts.Add(nqhAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nqhAccount);
        }

        // GET: nqhAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhAccount nqhAccount = db.nqhAccounts.Find(id);
            if (nqhAccount == null)
            {
                return HttpNotFound();
            }
            return View(nqhAccount);
        }

        // POST: nqhAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NqhID,NqhUserName,NqhPassWord,NqhFullName,NqhEmail,NqhPhone,NqhActive")] NqhAccount nqhAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nqhAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nqhAccount);
        }

        // GET: nqhAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqhAccount nqhAccount = db.nqhAccounts.Find(id);
            if (nqhAccount == null)
            {
                return HttpNotFound();
            }
            return View(nqhAccount);
        }

        // POST: nqhAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NqhAccount nqhAccount = db.nqhAccounts.Find(id);
            db.nqhAccounts.Remove(nqhAccount);
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
        // login
        public ActionResult NqhLogin()
        {
            var nqhModel = new NqhAccount();
            return View(nqhModel);
        }
        [HttpPost]
        public ActionResult NqhLogin(NqhAccount nqhAccount)
        {
            var nqhCheck = db.nqhAccount.Where(x => x.NqhUserName.Equals(nqhAccount.NqhUserName) && x.NqhPassWord.Equals(nqhAccount.NqhPassWord)).First0rDefault();
            if (nqhCheck != null)
            {
                //Lưu session 
                Session["nqhAccount"] = nqhCheck;
                return Redirect("/");

            }
            return View(nqhAccount);
        }
    }

}
