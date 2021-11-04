using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLW.Models
{
    public class KhuyenMaiModel
    {
        public string maKM { get; set; }
        public string tenKM { get; set; }
        public long phanTram { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime hieuLuc { get; set; }
        public bool daXoa { get; set; }
        public ICollection<SanPhamModel> SanPhams { get; set; }
    }
}
