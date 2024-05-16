using nqh_lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nqh_lesson04.Controllers
{
    public class NqhCustomerController : Controller
    {
        // GET: NqhCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NqhCustomerDetail
        public ActionResult NqhCustomerDetail()
        {
            // Tạo đối tượng dữ liệu
            var customer = new NqhCustomer()
            {
                CustomerId = 1,
                FistName = "Nguyễn Quang",
                LastName = "Huy",
                Address = "K22CNT4",
                YearOfbirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }

        // GET: NqhListCustomer
        public ActionResult NqhListCustomer()
        {
            var list = new List<NqhCustomer>()
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
            ViewBag.list = list; // Đưa dữ liệu ra view bằng đối tượng ViewBag

            return View(list);
        }
    }
}