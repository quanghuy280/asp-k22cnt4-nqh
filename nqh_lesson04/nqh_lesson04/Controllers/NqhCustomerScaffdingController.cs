using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nqh_lesson04.Models;

namespace nqh_lesson04.Controllers
{
    public class NqhCustomerScaffdingController : Controller
    {
        //mockdata
        private List<NqhCustomer> listCustomer = new List<NqhCustomer>()
            {
                new NqhCustomer()
                {
                    CustomerId = 1,
                    FistName = "Nguyễn Quang",
                    LastName = "Huy",
                    Address = "K22CNT4",
                    YearOfbirth = 2004
                },
                new NqhCustomer()
                {
                    CustomerId=2,
                    FistName="Nguyễn Văn",
                    LastName="Hiếu",
                    Address="K22CNT4",
                    YearOfbirth = 2004
                },
                new NqhCustomer()
                {
                    CustomerId=3,
                    FistName="Nguyễn Văn",
                    LastName="Hiếu",
                    Address="K22CNT4",
                    YearOfbirth = 2004
                },
            };

        // GET: NqhCustomerScaffding
        public ActionResult Index()
        {
            return View();
        }
    }
}