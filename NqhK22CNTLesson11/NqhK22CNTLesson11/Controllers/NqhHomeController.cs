using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NqhK22CNTLesson11.Controllers
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
            ViewBag.MSV = "2210900105";
            ViewBag.FullName = "Nquyễn quang Huy";  

            return View();
        }
    }
}