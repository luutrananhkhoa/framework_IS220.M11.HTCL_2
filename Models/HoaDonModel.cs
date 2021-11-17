using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class HoaDonModel
    {
        [Display(Name = "Số Hóa Đơn")]
        public string soHD { get; set; }

        [Display(Name = "Mã Khách Hàng")]
        [ForeignKey("maKH")]
        public string maKH { get; set; }

        [Display(Name = "Mã NVVC")]
        [ForeignKey("maNVVC")]
        public string maNVVC { get; set; }

        [Display(Name = "Khấu trừ")]
        public long khauTru { get; set; }

        [Display(Name = "Mã Nhân Viên")]
        [ForeignKey("maNV")]
        public string maNV { get; set; }

        [Display(Name = "Tổng Giá")]
        public long tongGia { get; set; }

        [Display(Name = "Tổng Số Lượng")]
        public long tongSL { get; set; }

        [Display(Name = "Tình Trạng")]
        public string tinhTrang { get; set; }

        [Display(Name = "Ngày Tạo")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngayLapHD { get; set; }

        [Display(Name = "Ngày Nhận")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngayHoanTat { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }

        //public ICollection<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }
        //public KhachHangModel KhachHangs { get; set; }
        //public NhanVienModel NhanViens { get; set; }
        //public NhanVienVCModel NhanVienVCs { get; set; }
    }
}
