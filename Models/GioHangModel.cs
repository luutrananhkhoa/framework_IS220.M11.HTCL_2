using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class GioHangModel
    {
        [Display(Name = "Mã Khách Hàng")]
        public string maKH { get; set; }
        [ForeignKey("maKH")]
        [Display(Name = "Mã Sản Phẩm")]
        public string maSP { get; set; }
        [ForeignKey("maSP")]
        [Display(Name = "Số Lượng")]
        public int soLuong { get; set; }
        //public SanPhamModel SanPhams { get; set; }
        //public KhachHangModel KhachHangs { get; set; }
    }
}
