using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class NhanVienVCModel
    {
        [Display(Name = "Mã NVVC")]
        public string maNVVC { get; set; }
        [Display(Name = "Tên NVVC")]
        public string tenNVVC { get; set; }
        [Display(Name = "Ngày Sinh")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngaySinh { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string diaChi { get; set; }
        [Display(Name = "SĐT")]
        public string SDT { get; set; }
        [Display(Name = "Giới Tính")]
        public string gioiTinh { get; set; }
        [Display(Name = "Lương Cơ Bản")]
        public long luongCoBan { get; set; }
        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }

        //public UuserModel Uusers { get; set; }
        //public ICollection<HoaDonModel> HoaDons { get; set; }
    }
}
