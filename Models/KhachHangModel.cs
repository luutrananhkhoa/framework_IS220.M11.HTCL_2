using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class KhachHangModel
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public string gioiTinh { get; set; }
        public long diemTichLuy { get; set; }
        public string loaiKhachHang { get; set; }
        public long CMND { get; set; }
        public string hinhChup { get; set; }
        public bool daXoa { get; set; }
        //public UuserModel Uusers { get; set; }
        public ICollection<HoaDonModel> HoaDons { get; set; }

    }
}
