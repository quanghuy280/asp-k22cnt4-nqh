using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NqhLesson06.Models
{
    public class NqhBookStore:DbContext
    {
        public NqhBookStore():base() { }

        // Khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<NqhCategory> nqhCategories { get; set; }
        public DbSet<NqhBook> nqhBooks { get; set; }

    }
}