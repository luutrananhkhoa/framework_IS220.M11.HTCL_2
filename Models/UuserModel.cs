using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class UuserModel
    {
        [Display(Name = "Mã User")]
        public string maUser { get; set; }
        [Display(Name = "Mã Khách Hàng")]
        public string maKH { get; set; }
        //[ForeignKey("maKH")]
        [Display(Name = "Mã Nhân Viên")]
        public string maNV { get; set; }
        //[ForeignKey("maNV")]
        [Display(Name = "Mã NVVC")]
        public string maNVVC { get; set; }
        //[ForeignKey("maNVVC")]
        [Display(Name = "Username")]
        public string uuserName { get; set; }
        [Display(Name = "Password")]
        public string ppassWord { get; set; }
        [Display(Name = "Cập Nhật")]
        public bool uUPDATE { get; set; }
        [Display(Name = "Khởi Tạo")]
        public bool cCREATE { get; set; }
        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }
        //public KhachHangModel KhachHangs { get; set; }
        //public NhanVienModel NhanViens { get; set; }
        //public NhanVienVCModel NhanVienVCs { get; set; }
    }
}
