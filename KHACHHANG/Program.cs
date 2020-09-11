using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KHACHHANG
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLy quanly = new QuanLy();
            KhachHang kh = new KhachHangVN(631,"bui the minh hieu",5,6000,100,"hocsinh");
            quanly.NhapTTKhachHang();
            quanly.ThemKH(kh);
            quanly.XoaKH(631);
            quanly.dsCuoiCung();
        }
    }
}
