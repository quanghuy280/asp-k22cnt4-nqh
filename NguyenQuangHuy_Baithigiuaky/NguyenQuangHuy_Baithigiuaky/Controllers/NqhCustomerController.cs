using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenQuangHuy_Baithigiuaky.Models;

namespace NguyenQuangHuy_Baithigiuaky.Controllers
{
    public class NqhCustomerController : Controller

    {
        private static List<NqhCustomer> customers = new List<NqhCustomer>()
    {
        new NqhCustomer { msv_CustId = "2210900105", Nqh_FullName = "Nguyễn Quang Huy", Nqh_Address = "K22cnt4", Nqh_Email = "nguyenquangh661@example.com", Nqh_Phone = "0123456789", Nqh_Balance = 100 },
        new NqhCustomer { msv_CustId = "2", Nqh_FullName = "Lê Văn Vũ", Nqh_Address = "456 Avenue, Town", Nqh_Email = "jane@example.com", Nqh_Phone = "0987654321", Nqh_Balance = 150 },
    };


        // GET: NqhCustomer
        public ActionResult NqhIndex()
        {
            return View(customers);
        }
    }
}