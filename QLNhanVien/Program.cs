using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien
{
    class Program
    {
        static void Main(string[] args)
        {

            QuanLy p = new QuanLy();
            NhanVien nv1 = new NVHanhChinh("123", "Hung", "Su Van Hanh", "0932154892", "15/1/2002", 2.2);
            NhanVien nv2 = new NVHanhChinh("456", "Thanh", "Su Van Hanh", "0918759465", "15/1/2002", 2.6);
            p.NhapDSNhanVien();
            p.ThemNV(nv1);
            p.ThemNV(nv2);
            p.XoaNV("123");
            NVHanhChinh.setLuongCB(4000000);
            p.DSNVsaukhisuachua();
           // NVHanhChinh.setLuongCB(4000000);
            p.DSNVLuongDuoiTB();







        }
    }
}
