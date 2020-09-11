using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timsonhonhat_cach2_
{
    class Program
    {
        static void Nhap(out int[] a, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static int timKiem( int[] a, int n)
        {
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                if (left == right)
                    return a[left];
                if (a[left] <= a[right])
                {
                    right--;
                }
                else left++;
            }
            return -1;
        }
        static void ketQua(int[] a, int n)
        {
            Console.WriteLine(timKiem(a,n));
        }

        static void Main(string[] args)
        {
            int[] a = new int[900];
            int n;
            Nhap(out a, out n);
            ketQua(a,n);
        }
    }
}
