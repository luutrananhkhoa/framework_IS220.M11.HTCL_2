using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class NhanVienModel
    {
        public string maNV { get; set; }
        public string tenNV { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public string gioiTinh { get; set; }
        public long luongCoBan { get; set; }
        public string chucVu { get; set; }
        public string maChiNhanh { get; set; }
        public bool daXoa { get; set; }

        //public UuserModel Uusers { get; set; }
        public ICollection<HoaDonModel> HoaDons { get; set; }

        public ChiNhanhModel ChiNhanhs { get; set; }
    }
}
