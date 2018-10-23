using STK.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STK
{
    class NganHang
    {
        public string MaNganHang { get; set; }
        public string TenNganHang { get; set; }
        public List<TheTietKiem> TheTietKiems { get; set; }
    }
}
