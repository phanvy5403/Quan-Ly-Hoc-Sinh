﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHocSinh
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dataEntities : DbContext
    {
        public dataEntities()
            : base("name=dataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTLOP> CTLOPs { get; set; }
        public virtual DbSet<DIEM> DIEMs { get; set; }
        public virtual DbSet<HOCKY> HOCKies { get; set; }
        public virtual DbSet<HOCSINH> HOCSINHs { get; set; }
        public virtual DbSet<KETQUA_MONHOC_HOCSINH> KETQUA_MONHOC_HOCSINH { get; set; }
        public virtual DbSet<KHOI> KHOIs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NAMHOC> NAMHOCs { get; set; }
        public virtual DbSet<PHANQUYEN> PHANQUYENs { get; set; }
        public virtual DbSet<THANHPHAN> THANHPHANs { get; set; }
        public virtual DbSet<XEPLOAI> XEPLOAIs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    
        public virtual int ThemHocKy(string maHocKy, string hocKy, Nullable<double> trongSo)
        {
            var maHocKyParameter = maHocKy != null ?
                new ObjectParameter("MaHocKy", maHocKy) :
                new ObjectParameter("MaHocKy", typeof(string));
    
            var hocKyParameter = hocKy != null ?
                new ObjectParameter("HocKy", hocKy) :
                new ObjectParameter("HocKy", typeof(string));
    
            var trongSoParameter = trongSo.HasValue ?
                new ObjectParameter("TrongSo", trongSo) :
                new ObjectParameter("TrongSo", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemHocKy", maHocKyParameter, hocKyParameter, trongSoParameter);
        }
    
        public virtual ObjectResult<TongKetMonHocKy_Result> TongKetMonHocKy(string maMonHoc, string maHocKy, string maNamHoc)
        {
            var maMonHocParameter = maMonHoc != null ?
                new ObjectParameter("MaMonHoc", maMonHoc) :
                new ObjectParameter("MaMonHoc", typeof(string));
    
            var maHocKyParameter = maHocKy != null ?
                new ObjectParameter("MaHocKy", maHocKy) :
                new ObjectParameter("MaHocKy", typeof(string));
    
            var maNamHocParameter = maNamHoc != null ?
                new ObjectParameter("MaNamHoc", maNamHoc) :
                new ObjectParameter("MaNamHoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TongKetMonHocKy_Result>("TongKetMonHocKy", maMonHocParameter, maHocKyParameter, maNamHocParameter);
        }
    
        public virtual int ThemHocSinh(string maHocSinh, string hoTen, string gioiTinh, Nullable<System.DateTime> ngaySinh, string diaChi, string queQuan, string danToc, string tonGiao, string sDT, string email, string hoTenCha, Nullable<short> namSinh_Cha, string cCCD_Cha, string sDT_Cha, string ngheNghiep_Cha, string hoTenMe, Nullable<short> namSinh_Me, string cCCD_Me, string sDT_Me, string ngheNghiep_Me)
        {
            var maHocSinhParameter = maHocSinh != null ?
                new ObjectParameter("MaHocSinh", maHocSinh) :
                new ObjectParameter("MaHocSinh", typeof(string));
    
            var hoTenParameter = hoTen != null ?
                new ObjectParameter("HoTen", hoTen) :
                new ObjectParameter("HoTen", typeof(string));
    
            var gioiTinhParameter = gioiTinh != null ?
                new ObjectParameter("GioiTinh", gioiTinh) :
                new ObjectParameter("GioiTinh", typeof(string));
    
            var ngaySinhParameter = ngaySinh.HasValue ?
                new ObjectParameter("NgaySinh", ngaySinh) :
                new ObjectParameter("NgaySinh", typeof(System.DateTime));
    
            var diaChiParameter = diaChi != null ?
                new ObjectParameter("DiaChi", diaChi) :
                new ObjectParameter("DiaChi", typeof(string));
    
            var queQuanParameter = queQuan != null ?
                new ObjectParameter("QueQuan", queQuan) :
                new ObjectParameter("QueQuan", typeof(string));
    
            var danTocParameter = danToc != null ?
                new ObjectParameter("DanToc", danToc) :
                new ObjectParameter("DanToc", typeof(string));
    
            var tonGiaoParameter = tonGiao != null ?
                new ObjectParameter("TonGiao", tonGiao) :
                new ObjectParameter("TonGiao", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var hoTenChaParameter = hoTenCha != null ?
                new ObjectParameter("HoTenCha", hoTenCha) :
                new ObjectParameter("HoTenCha", typeof(string));
    
            var namSinh_ChaParameter = namSinh_Cha.HasValue ?
                new ObjectParameter("NamSinh_Cha", namSinh_Cha) :
                new ObjectParameter("NamSinh_Cha", typeof(short));
    
            var cCCD_ChaParameter = cCCD_Cha != null ?
                new ObjectParameter("CCCD_Cha", cCCD_Cha) :
                new ObjectParameter("CCCD_Cha", typeof(string));
    
            var sDT_ChaParameter = sDT_Cha != null ?
                new ObjectParameter("SDT_Cha", sDT_Cha) :
                new ObjectParameter("SDT_Cha", typeof(string));
    
            var ngheNghiep_ChaParameter = ngheNghiep_Cha != null ?
                new ObjectParameter("NgheNghiep_Cha", ngheNghiep_Cha) :
                new ObjectParameter("NgheNghiep_Cha", typeof(string));
    
            var hoTenMeParameter = hoTenMe != null ?
                new ObjectParameter("HoTenMe", hoTenMe) :
                new ObjectParameter("HoTenMe", typeof(string));
    
            var namSinh_MeParameter = namSinh_Me.HasValue ?
                new ObjectParameter("NamSinh_Me", namSinh_Me) :
                new ObjectParameter("NamSinh_Me", typeof(short));
    
            var cCCD_MeParameter = cCCD_Me != null ?
                new ObjectParameter("CCCD_Me", cCCD_Me) :
                new ObjectParameter("CCCD_Me", typeof(string));
    
            var sDT_MeParameter = sDT_Me != null ?
                new ObjectParameter("SDT_Me", sDT_Me) :
                new ObjectParameter("SDT_Me", typeof(string));
    
            var ngheNghiep_MeParameter = ngheNghiep_Me != null ?
                new ObjectParameter("NgheNghiep_Me", ngheNghiep_Me) :
                new ObjectParameter("NgheNghiep_Me", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemHocSinh", maHocSinhParameter, hoTenParameter, gioiTinhParameter, ngaySinhParameter, diaChiParameter, queQuanParameter, danTocParameter, tonGiaoParameter, sDTParameter, emailParameter, hoTenChaParameter, namSinh_ChaParameter, cCCD_ChaParameter, sDT_ChaParameter, ngheNghiep_ChaParameter, hoTenMeParameter, namSinh_MeParameter, cCCD_MeParameter, sDT_MeParameter, ngheNghiep_MeParameter);
        }
    
        public virtual int ThemKhoi(string maKhoi, string tenKhoi)
        {
            var maKhoiParameter = maKhoi != null ?
                new ObjectParameter("MaKhoi", maKhoi) :
                new ObjectParameter("MaKhoi", typeof(string));
    
            var tenKhoiParameter = tenKhoi != null ?
                new ObjectParameter("TenKhoi", tenKhoi) :
                new ObjectParameter("TenKhoi", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemKhoi", maKhoiParameter, tenKhoiParameter);
        }
    
        public virtual int ThemLop(string maLop, string tenLop, string maKhoi, string maNamHoc)
        {
            var maLopParameter = maLop != null ?
                new ObjectParameter("MaLop", maLop) :
                new ObjectParameter("MaLop", typeof(string));
    
            var tenLopParameter = tenLop != null ?
                new ObjectParameter("TenLop", tenLop) :
                new ObjectParameter("TenLop", typeof(string));
    
            var maKhoiParameter = maKhoi != null ?
                new ObjectParameter("MaKhoi", maKhoi) :
                new ObjectParameter("MaKhoi", typeof(string));
    
            var maNamHocParameter = maNamHoc != null ?
                new ObjectParameter("MaNamHoc", maNamHoc) :
                new ObjectParameter("MaNamHoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemLop", maLopParameter, tenLopParameter, maKhoiParameter, maNamHocParameter);
        }
    
        public virtual int ThemMonHoc(string maMonHoc, string tenMonHoc)
        {
            var maMonHocParameter = maMonHoc != null ?
                new ObjectParameter("MaMonHoc", maMonHoc) :
                new ObjectParameter("MaMonHoc", typeof(string));
    
            var tenMonHocParameter = tenMonHoc != null ?
                new ObjectParameter("TenMonHoc", tenMonHoc) :
                new ObjectParameter("TenMonHoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemMonHoc", maMonHocParameter, tenMonHocParameter);
        }
    
        public virtual int ThemNamHoc(string maNamHoc, string namHoc)
        {
            var maNamHocParameter = maNamHoc != null ?
                new ObjectParameter("MaNamHoc", maNamHoc) :
                new ObjectParameter("MaNamHoc", typeof(string));
    
            var namHocParameter = namHoc != null ?
                new ObjectParameter("NamHoc", namHoc) :
                new ObjectParameter("NamHoc", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ThemNamHoc", maNamHocParameter, namHocParameter);
        }
    }
}
