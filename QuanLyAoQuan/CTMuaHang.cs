//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyAoQuan
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTMuaHang
    {
        public long mactmh { get; set; }
        public long masp { get; set; }
        public long mahd { get; set; }
        public long gia { get; set; }
        public int soluong { get; set; }
    
        public virtual HoaDonMH HoaDonMH { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
