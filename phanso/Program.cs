using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phanso
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            PhanSo p2 = new PhanSo();
            
            p1.NhapPhanSo();
            p2.NhapPhanSo();
        
            p1.In(); Console.Write(" + "); p2.In(); Console.Write("=");
            PhanSo kq1 = p1 + p2; Console.WriteLine(kq1.toString());
            p1.In(); Console.Write(" - "); p2.In(); Console.Write("=");
            PhanSo kq2 = p1 - p2; Console.WriteLine(kq2.toString());
            p1.In(); Console.Write(" * "); p2.In(); Console.Write("=");
            PhanSo kq3 = p1 * p2; Console.WriteLine(kq3.toString());
            p1.In(); Console.Write(" / "); p2.In(); Console.Write("=");
            PhanSo kq4 = p1 / p2; Console.WriteLine(kq4.toString());
            new PhanSo().sosanh(p1, p2);
            







        }
    }
}
