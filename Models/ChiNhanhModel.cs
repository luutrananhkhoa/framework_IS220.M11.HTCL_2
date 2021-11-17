using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class ChiNhanhModel
    {
        [Display(Name = "Mã Chi Nhánh")]
        public string maChiNhanh { get; set; }
        [Display(Name = "Tên Chi Nhánh")]
        public string tenChiNhanh { get; set; }
        [Display(Name = "Địa Chỉ")]
        public string diaChi { get; set; }
        [Display(Name = "SĐT")]
        public string SDT { get; set; }
        [Display(Name = "Ngày Thành Lập")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngayThanhLap { get; set; }
        [Display(Name = "Trưởng Chi Nhánh")]
        public string truongCN { get; set; }
        [ForeignKey("maNV")]
        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }

        //public ICollection<SanPhamModel> SanPhams { get; set; }
        //public ICollection<NhanVienModel> NhanViens { get; set; }
    }
}
