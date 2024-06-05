using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NguyenQuangHuy_Baithigiuaky.Models
{
    public class NqhCustomer{ 
        public string msv_CustId { get; set; }
        public string Nqh_FullName { get; set; }
        public string Nqh_Address { get; set; }
        public string Nqh_Email { get; set; }
        public string Nqh_Phone { get; set; }
        public int Nqh_Balance { get; set; }
    }
}