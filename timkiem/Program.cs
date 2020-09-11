using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timkiem
{
    class Program
    {
        static void Nhap(out int[] a, out int n, out int x)
        {
            string[] tokens = Console.ReadLine().Split();
            n = Convert.ToInt32(tokens[0]);
            x = Convert.ToInt32(tokens[1]);
            a = new int[n];
            for (int i = 0; i < n; i++)
            {

                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static int timKiem( int[] a,  int n, int x)
        {
            for (int i = 0; i < n; i++)

                if (a[i] == x)
                    return i + 1;
            return -1;
        }
        static void KetQua(int[] a, int n, int x)
        {
            Console.WriteLine(timKiem( a,  n,  x));
        }
        static void TatCaKQ(int[] a, int n, int x)
        {
            for (int i = 0; i < n; i++)
            {
                if (a[i]==x)
                    Console.WriteLine(i+1);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[900];
            int x, n;
            Nhap(out a, out n, out x);
            KetQua(a, n, x);
            TatCaKQ(a, n, x);
            //Console.WriteLine(timKiem(ref a,ref n,ref x));




        }
    }
}
