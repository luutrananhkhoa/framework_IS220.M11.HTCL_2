using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class KhachHangModel
    {
        [Display (Name = "Mã Khách Hàng")]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string maKH { get; set; }
        [Display(Name = "Tên Khách Hàng")]
        public string tenKH { get; set; }
        [Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngaySinh { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string diaChi { get; set; }
        [Display(Name = "SĐT")]
        public string SDT { get; set; }
        [Display(Name = "Giới Tính")]
        public string gioiTinh { get; set; }
        [Display(Name = "Điểm Tích Lũy")]
        public long diemTichLuy { get; set; }
        [Display(Name = "Loại Khách Hàng")]
        public string loaiKhachHang { get; set; }
        [Display (Name = "CMND")]
        public long CMND { get; set; }
        [Display(Name = "Hình Chụp")]
        public string hinhChup { get; set; }
        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }
        //public UuserModel Uusers { get; set; }
        ///public ICollection<HoaDonModel> HoaDons { get; set; }
        //public ICollection<GioHangModel> GioHangs { get; set; }
    }
}
