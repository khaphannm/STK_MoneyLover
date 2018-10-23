using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STK.Entity
{
    class TheTietKiem
    {
        public int ID { get; set; }
        public string MaSo { get; set; }
        public string Email { get; set; }
        public string MaNganHang { get; set; }
        public DateTime NgayGui { get; set; }
        public double SoTienGui { get; set; }
        public double LaiSuat { get; set; }
        public string KhiDenHan { get; set; }
        public string TraLai { get; set; }
        public string KyHan { get; set; }
        public double KhongKyHan { get; set; }
        public bool TatToan { get; set; }
        public double TienLai { get; set; }
    }
}
