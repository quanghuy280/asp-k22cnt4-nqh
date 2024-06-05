using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NqhLesson06.Models
{
    public class NqhCategory
    {
        public int NqhId { get; set; }
        public string NqhCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<NqhBook> NqhBooks { get; set; }
    }
}