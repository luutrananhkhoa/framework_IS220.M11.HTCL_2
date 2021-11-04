using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QLW.Models;

namespace QLW.Data
{
    public class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            context.Database.EnsureCreated();

            var khachhangs = new KhachHangModel []
            {
                new KhachHangModel{maKH="KH0001",tenKH="Alexander",ngaySinh=DateTime.Parse("2001-11-03"),diaChi="TP.HCM"
                , gioiTinh="Nam", SDT="0358795564", diemTichLuy=1500,loaiKhachHang="Tiem Nang", CMND=321456789
                , hinhChup="0001X22220", daXoa=false},
                new KhachHangModel{maKH="KH0002",tenKH="Phan Thi B",ngaySinh=DateTime.Parse("1987-10-09"),diaChi="Long An"
                , gioiTinh="Nu", SDT="0367895264", diemTichLuy=0,loaiKhachHang="Tiem Nang", CMND=321457459
                , hinhChup="0001X22220", daXoa=false},
                new KhachHangModel{maKH="KH0003",tenKH="Pham Van E",ngaySinh=DateTime.Parse("1999-04-27"),diaChi="TP.HCM"
                , gioiTinh="Nam", SDT="0355566564", diemTichLuy=10000,loaiKhachHang="Than Thiet", CMND=321364785
                , hinhChup="0001X22220", daXoa=false},
            };
            foreach (KhachHangModel s in khachhangs)
            {
                context.KhachHangs.Add(s);
            }
            //context.SaveChanges();

            var nhanviens = new NhanVienModel[]
            {
                new NhanVienModel{maNV="NV0001",tenNV="Nguyen Van A",ngaySinh=DateTime.Parse("1990-05-11"),diaChi="TP.HCM"
                , gioiTinh="Nam", SDT="0358795564", luongCoBan=15000000, chucVu="Cua hang truong", maChiNhanh="CN0001"
                , daXoa=false},
                new NhanVienModel{maNV="NV0002",tenNV="Truong Thi C",ngaySinh=DateTime.Parse("1995-04-13"),diaChi="TP.HCM"
                , gioiTinh="Nu", SDT="0358797895", luongCoBan=15000000, chucVu="Cua hang truong", maChiNhanh="CN0001"
                , daXoa=false},
                new NhanVienModel{maNV="NV0003",tenNV="Nguyen Thi T",ngaySinh=DateTime.Parse("1992-12-11"),diaChi="TP.HCM"
                , gioiTinh="Nu", SDT="0357841124", luongCoBan=15000000, chucVu="Cua hang pho", maChiNhanh="CN0002"
                , daXoa=false},
                new NhanVienModel{maNV="NV0004",tenNV="Tran Van H",ngaySinh=DateTime.Parse("1997-08-27"),diaChi="TP.HCM"
                , gioiTinh="Nam", SDT="0357841124", luongCoBan=15000000, chucVu="Cua hang pho", maChiNhanh="CN0002"
                , daXoa=false},
            };
            foreach (NhanVienModel s in nhanviens)
            {
                context.NhanViens.Add(s);
            }
            //context.SaveChanges();

            var chinhanhs = new ChiNhanhModel[]
            {
                new ChiNhanhModel{maChiNhanh="CN0001", tenChiNhanh="Store01", diaChi="TP.HCM", truongCN="NV0001"
                , ngayThanhLap=DateTime.Parse("2020-07-07"), SDT="0275987556", daXoa=false},
                new ChiNhanhModel{maChiNhanh="CN0002", tenChiNhanh="Store02", diaChi="TP.HCM", truongCN="NV0002"
                , ngayThanhLap=DateTime.Parse("2020-07-07"), SDT="0275987556", daXoa=false},
            };
            foreach (ChiNhanhModel c in chinhanhs)
            {
                context.ChiNhanhs.Add(c);
            }
            //context.SaveChanges();


            var nhanvienvcs = new NhanVienVCModel[]
            {
                new NhanVienVCModel{maNVVC="VC0001",tenNVVC="Tran Van X",ngaySinh=DateTime.Parse("1994-07-07"),diaChi="TP.HCM"
                , gioiTinh="Nam", SDT="0358742588", luongCoBan=7500000, daXoa=false},
            };
            foreach (NhanVienVCModel n in nhanvienvcs)
            {
                context.NhanVienVCs.Add(n); 
            }
            context.SaveChanges();

        }
    }
}
