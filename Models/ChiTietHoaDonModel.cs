﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class ChiTietHoaDonModel
    {
        [Display(Name = "Số Hóa Đơn")]
        public string soHD { get; set; }
        [ForeignKey("soHD")]
        [Display(Name = "Mã Sản Phẩm")]
        public string maSP { get; set; }
        [ForeignKey("maSP")]
        [Display(Name = "Số Lượng")]
        public int soLuong { get; set; }
        [Display(Name = "Thành Tiền")]
        public long thanhTien { get; set; }
      
        //public SanPhamModel SanPhams { get; set; }
        //public HoaDonModel HoaDons { get; set; }
    }
}
