﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLAQEntities : DbContext
    {
        public QLAQEntities()
            : base("name=QLAQEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_Admin> C_Admin { get; set; }
        public virtual DbSet<CTBanHang> CTBanHangs { get; set; }
        public virtual DbSet<CTMuaHang> CTMuaHangs { get; set; }
        public virtual DbSet<HoaDonBH> HoaDonBHs { get; set; }
        public virtual DbSet<HoaDonMH> HoaDonMHs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Loai> Loais { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
