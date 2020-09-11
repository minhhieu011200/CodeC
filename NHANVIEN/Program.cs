using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHANVIEN
{
    class Program
    {
        static void TinhLuong(NhanVien[] nv)
        {
            for (int i = 0; i < nv.Length; i++)
                Console.WriteLine(nv[i].toString());
        }
        static void Main(string[] args)
        {
            NhanVien[] nNV = new NhanVien[4];
            nNV[0] = new NVKinhDoanh("15", "A", 2000, 2);
            nNV[1] = new NVKinhDoanh("16", "B", 3000, 2);
            nNV[2] = new NVSanXuat("17", "C", 4000);
            nNV[3] = new NVSanXuat("18", "D", 2000);

            TinhLuong(nNV);

        }
    }
}

