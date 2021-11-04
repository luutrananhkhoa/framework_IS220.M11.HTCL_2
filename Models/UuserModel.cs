using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class UuserModel
    {
        public string maUser { get; set; }
        public string maKH { get; set; }
        public string maNV { get; set; }
        public string maNVVC { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public bool capNhat { get; set; }
        public bool khoiTao { get; set; }
        public bool daXoa { get; set; }
        //public KhachHangModel KhachHangs { get; set; }
        //public NhanVienModel NhanViens { get; set; }
        //public NhanVienVCModel NhanVienVCs { get; set; }
    }
}
