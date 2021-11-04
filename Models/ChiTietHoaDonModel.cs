using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class ChiTietHoaDonModel
    {
        public string soHD { get; set; }
        public string maSP { get; set; }
        public int soLuong { get; set; }
        public long thanhTien { get; set; }

        public SanPhamModel SanPhams { get; set; }
        public HoaDonModel HoaDons { get; set; }
    }
}
