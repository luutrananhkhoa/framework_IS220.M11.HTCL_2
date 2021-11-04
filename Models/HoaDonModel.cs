using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class HoaDonModel
    {
        public string soHD { get; set; }
        public string maKH { get; set; }
        public string maNVVC { get; set; }
        public long khauTru { get; set; }
        public string maNV { get; set; }
        public long tongGia { get; set; }
        public long tongSL { get; set; }
        public string tinhTrang { get; set; }
        public DateTime ngayLapHD { get; set; }
        public DateTime ngayHoanTat { get; set; }
        public bool daXoa { get; set; }

        public ICollection<ChiTietHoaDonModel> ChiTietHoaDons { get; set; }

        public KhachHangModel KhachHangs { get; set; }
        public NhanVienModel NhanViens { get; set; }
        public NhanVienVCModel NhanVienVCs { get; set; }
    }
}
