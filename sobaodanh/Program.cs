using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobaodanh
{
    class Program
    {
        static void Main(string[] args)
        {

            int m, n;
            do
            {
                int dem = 0;
                Console.Write("Nhap so bao danh: ");
                n = Convert.ToInt32(Console.ReadLine());
                m = n;
                while (m != 0)
                {
                    m = m / 10;
                    dem++;
                }
                for (int i = 0; i < 6 - dem; i++)
                {
                    Console.Write("0");
                }
                Console.Write(n);
                Console.WriteLine();

            }
            while (n != 0);
        }





    }
}

