using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class NhanVienVCModel
    {
        public string maNVVC { get; set; }
        public string tenNVVC { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public string gioiTinh { get; set; }
        public long luongCoBan { get; set; }
        public bool daXoa { get; set; }
        //public UuserModel Uusers { get; set; }
        public ICollection<HoaDonModel> HoaDons { get; set; }
    }
}
