using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class KhuyenMaiModel
    {
        [Display(Name = "Mã Khuyến Mãi")]
        public string maKM { get; set; }
        [Display(Name = "Chương Trình")]
        public string tenKM { get; set; }
        [Display(Name = "Giảm")]
        public long phanTram { get; set; }
        [Display(Name = "Ngày Bắt Đầu")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ngayBatDau { get; set; }
        [Display(Name = "Hiệu Lực")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime hieuLuc { get; set; }
        [Display(Name = "Đã Xóa")]
        public bool daXoa { get; set; }
        //public ICollection<SanPhamModel> SanPhams { get; set; }
    }
}
