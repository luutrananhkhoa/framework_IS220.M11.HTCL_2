using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class SanPhamModel
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string hangSX { get; set; }
        public string mauSac { get; set; }
        public string dungLuong { get; set; }
        public string RAM { get; set; }
        public string CAMERA { get; set; }
        public string BLUETOOTH { get; set; }
        public long soLuong { get; set; }
        public long GIA { get; set; }
        public long giaKM { get; set; }
        public string maChuongTrinh { get; set; }
        public string anh1 { get; set; }
        public string anh2 { get; set; }
        public string anh3 { get; set; }
        public string anh4 { get; set; }
        public string namSX { get; set; }
        public string maChiNhanh { get; set; }
        public string ghiChu { get; set; }
        public bool daXoa { get; set; }
        public ICollection<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }

        public KhuyenMaiModel KhuyenMais { get; set; }
        public ChiNhanhModel ChiNhanhs { get; set; }
    }
}
