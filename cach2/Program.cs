
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cach2
{
    class Program
    {
        static bool kiemTraSoNguyenTo(int x)
        {
            if (x < 2)

                return false;

            for (int i = 2; i < x; i++)

                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int j=2;j<=n;j++)
            {
                if(kiemTraSoNguyenTo(j)==true)
                    Console.Write(j+" ");
            }


            




        }
    }
}
