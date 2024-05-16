using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nqh_lesson04.Models
{
    public class NqhCustomer
    {
        public int CustomerId { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int YearOfbirth { get; set; }
    }
}