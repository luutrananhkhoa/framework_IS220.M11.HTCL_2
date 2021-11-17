using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class SanPhamModel
    {
        [Display(Name = "Mã Sản Phẩm")]
        public string maSP { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        public string tenSP { get; set; }

        [Display(Name = "Hãng Sản Xuất")]
        public string hangSX { get; set; }

        [Display(Name = "Màu Sắc")]
        public string mauSac { get; set; }

        [Display(Name = "Dung Lượng")]
        public string dungLuong { get; set; }

        [Display(Name = "RAM")]
        public string RAM { get; set; }

        [Display(Name = "CAMERA")]
        public string CAMERA { get; set; }

        [Display(Name = "BLUETOOTH")]
        public string BLUETOOTH { get; set; }

        [Display(Name = "Số Lượng")]
        public long soLuong { get; set; }

        [Display(Name = "Giá")]
        public long GIA { get; set; }

        [Display(Name = "Giá Khuyến Mại")]
        public long giaKM { get; set; }

        [Display(Name = "Mã Chương Trình")]
        [ForeignKey("maKM")]
        public string maChuongTrinh { get; set; }

        [Display(Name = "Ảnh 1")]
        public string anh1 { get; set; }

        [Display(Name = "Ảnh 2")]
        public string anh2 { get; set; }

        [Display(Name = "Ảnh 3")]
        public string anh3 { get; set; }

        [Display(Name = "Ảnh 4")]
        public string anh4 { get; set; }

        [Display(Name = "Năm Sản Xuất")]
        public string namSX { get; set; }

        [Display(Name = "Mã Chi Nhánh")]
        [ForeignKey("maChiNhanh")]
        public string maChiNhanh { get; set; }

        [Display(Name = "Ghi Chú")]
        public string ghiChu { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }

        //public ICollection<GioHangModel> GioHangs { get; set; }
        //public ICollection<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }
        //public KhuyenMaiModel KhuyenMais { get; set; }
        //public ChiNhanhModel ChiNhanhs { get; set; }
    }
}
