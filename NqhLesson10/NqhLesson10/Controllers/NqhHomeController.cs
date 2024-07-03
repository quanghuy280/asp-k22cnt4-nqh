using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NqhLesson10.Controllers
{
    public class NqhHomeController : Controller
    {
        public ActionResult NqhIndex()
        {
            return View();
        }

        public ActionResult NqhAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NqhContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}