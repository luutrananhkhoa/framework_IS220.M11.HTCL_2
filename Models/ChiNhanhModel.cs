using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class ChiNhanhModel
    {
        public string maChiNhanh { get; set; }
        public string tenChiNhanh { get; set; }
        public string diaChi { get; set; }
        public string SDT { get; set; }
        public DateTime ngayThanhLap { get; set; }
        public string truongCN { get; set; }
        public bool daXoa { get; set; }

        public ICollection<SanPhamModel> SanPhams { get; set; }
        public ICollection<NhanVienModel> NhanViens { get; set; }

    }
}
