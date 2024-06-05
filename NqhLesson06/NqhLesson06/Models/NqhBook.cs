using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NqhLesson06.Models
{
    public class NqhBook
    {
        public int NqhId { get; set; }
        public string NqhTitle { get; set; }
        public string NqhAuthor { get; set; }
        public int NqhYear { get; set; }
        public string NqhPulisher { get; set; }
        public string NqhPicture { get; set; }
        public int NqhCategoryId { get; set; }
        // Thuộc tính quan hệ
        public virtual NqhCategory NqhCategory { get; set; }


    }
}