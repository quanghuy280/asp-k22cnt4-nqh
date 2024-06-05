using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NqhLesson06.Controllers
{
    public class NqhCategoriesController : Controller
    {
        // GET: NqhCategories
        public ActionResult NqhIndex()
        {
            /*
             * khởi tạo DbContext:
             * Ep sẽ tìm thông tin kết nối trong file machinee.config của .Net Framework trên máy
             * và sau đó tạo csdl
             * */
            Models.NqhBookStore nqhDb = new Models.NqhBookStore();
            var NqhCategories = nqhDb.nqhCategories.ToList();
            return View(NqhCategories);
        }
    }
}