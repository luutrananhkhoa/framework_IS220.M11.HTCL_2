using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QLW.Models;

namespace QLW.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {

        }

        public DbSet<UuserModel> Uusers { get; set; }
        public DbSet<NhanVienModel> NhanViens { get; set; }
        public DbSet<NhanVienVCModel> NhanVienVCs { get; set; }
        public DbSet<KhachHangModel> KhachHangs { get; set; }
        public DbSet<KhuyenMaiModel> KhuyenMais { get; set; }
        public DbSet<SanPhamModel> SanPhams { get; set; }
        public DbSet<ChiNhanhModel> ChiNhanhs { get; set; }
        public DbSet<HoaDonModel> HoaDons { get; set; }
        public DbSet<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UuserModel>().ToTable("User").HasKey(c => c.maUser);
            //modelBuilder.Entity<UuserModel>().HasOne(n => n.KhachHangs).WithOne(u => u.Uusers).HasForeignKey("BlogForeignKey");
            //modelBuilder.Entity<UuserModel>().HasOne(n => n.NhanViens).WithOne(u => u.Uusers);
            //modelBuilder.Entity<UuserModel>().HasOne(n => n.NhanVienVCs).WithOne(u => u.Uusers);

            modelBuilder.Entity<NhanVienModel>().ToTable("NhanVien").HasKey(c => c.maNV);
            modelBuilder.Entity<NhanVienModel>().HasOne(c => c.ChiNhanhs).WithMany(n => n.NhanViens);
            modelBuilder.Entity<NhanVienModel>().HasMany(h => h.HoaDons).WithOne();
            //modelBuilder.Entity<NhanVienModel>().HasOne(u => u.Uusers).WithOne(n => n.NhanViens);

            modelBuilder.Entity<NhanVienVCModel>().ToTable("NhanVienVC").HasKey(c => c.maNVVC);
            modelBuilder.Entity<NhanVienVCModel>().HasMany(h => h.HoaDons).WithOne();
            //modelBuilder.Entity<NhanVienVCModel>().HasOne(u => u.Uusers).WithOne(n => n.NhanVienVCs);

            modelBuilder.Entity<KhachHangModel>().ToTable("KhachHang").HasKey(c => c.maKH);
            modelBuilder.Entity<KhachHangModel>().HasMany(h => h.HoaDons).WithOne();
            //modelBuilder.Entity<KhachHangModel>().HasOne(u => u.Uusers).WithOne(k => k.KhachHangs).HasForeignKey<UuserModel>(m => m.BlogForeignKey);

            modelBuilder.Entity<KhuyenMaiModel>().ToTable("KhuyenMai").HasKey(c => c.maKM);
            modelBuilder.Entity<KhuyenMaiModel>().HasMany(k => k.SanPhams).WithOne();

            modelBuilder.Entity<SanPhamModel>().ToTable("SanPham").HasKey(c => c.maSP);
            modelBuilder.Entity<SanPhamModel>().HasOne(k => k.KhuyenMais).WithMany(s => s.SanPhams);
            modelBuilder.Entity<SanPhamModel>().HasOne(c => c.ChiNhanhs).WithMany(s => s.SanPhams);
            modelBuilder.Entity<SanPhamModel>().HasMany(k => k.ChiTietHoaDons).WithOne();

            modelBuilder.Entity<ChiNhanhModel>().ToTable("ChiNhanh").HasKey(c => c.maChiNhanh);
            modelBuilder.Entity<ChiNhanhModel>().HasMany(s => s.SanPhams).WithOne();
            modelBuilder.Entity<ChiNhanhModel>().HasMany(n => n.NhanViens).WithOne();

            modelBuilder.Entity<HoaDonModel>().ToTable("HoaDon").HasKey(c => c.soHD);
            modelBuilder.Entity<HoaDonModel>().HasOne(n => n.NhanViens).WithMany(h => h.HoaDons);
            modelBuilder.Entity<HoaDonModel>().HasOne(n => n.NhanVienVCs).WithMany(h => h.HoaDons);
            modelBuilder.Entity<HoaDonModel>().HasOne(n => n.KhachHangs).WithMany(h => h.HoaDons);
            modelBuilder.Entity<HoaDonModel>().HasMany(k => k.ChiTietHoaDons).WithOne();

            modelBuilder.Entity<ChiTietHoaDonModel>().ToTable("ChiTietHoaDon").HasKey(nameof(ChiTietHoaDonModel.soHD), nameof(ChiTietHoaDonModel.maSP));
            modelBuilder.Entity<ChiTietHoaDonModel>().HasOne(s => s.SanPhams).WithMany(c => c.ChiTietHoaDons);
            modelBuilder.Entity<ChiTietHoaDonModel>().HasOne(h => h.HoaDons).WithMany(c => c.ChiTietHoaDons);
        }

    }
}
