using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SINHVIEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<SinhVien> DSSV = new List<SinhVien>(n);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin NV thu {0}", i + 1);
                SinhVien p = new SinhVien();
                p.Nhap();
                DSSV.Add(p);
            }
            foreach(var x in DSSV)
            {
                Console.WriteLine(x.toString());
            }
        }
    }
}
