//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NqhBaiKiemTraGK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nqhSinhVien
    {
        public string NqhMaSV { get; set; }
        public string NqhHoSV { get; set; }
        public string NqhTenSV { get; set; }
        public Nullable<System.DateTime> nqhNgaySinh { get; set; }
        public Nullable<bool> NqhPhai { get; set; }
        public string NqhPhone { get; set; }
        public string NqhEmail { get; set; }
        public string MaKH { get; set; }
        public string NqhMaKH { get; set; }
    
        public virtual NqhKhoa NqhKhoa { get; set; }
    }
}