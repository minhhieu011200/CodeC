using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void nhapMang(out int []a,out int n)
        {
            Console.WriteLine("Nhap so luong phan tu n: ");
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
                for (int i=0;i<a.Length;i++)
            {
                Console.Write("Nhap phan tu thu {0}: ",i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
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

            int n;
            int[] a = new int[2];
            nhapMang(out a,out n);
            for (int i=0;i<n;i++)
            if (kiemTraSoNguyenTo(a[i])==true)
                {
                    Console.WriteLine("la so nguyen to");
                }
                else Console.WriteLine("ko la so nguyen to ");
            
        }
    }
}
