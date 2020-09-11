using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demsoluong_cach2_
{
    class Program
    {
        static void nhapMang(out int[] a, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        static void xuLy(int[] a, int n, out int[] count)
        {
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                max = (a[i] > max) ? a[i] : max;
            }
            count = new int[max + 1];
            for (int i = 0; i < n; i++)
            {
                count[a[i]]++;
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                    Console.WriteLine("{0}:{1}", i, count[i]);
            }

        }
        static void timLon(int[] count, int[] a, int n)
        {
            int min = 0;
            for (int i = 0; i < count.Length; i++)
            {
                
                count[min] = 0;
                if (count[i] > count[min])
                {
                    count[min] = count[i];
                }
            }

            for (int j = 0; j < count.Length; j++)
            {
                if (count[min] == count[j])
                {
                    Console.WriteLine(j);
                }
            }


        }

        static void Main(string[] args)
        {
            int[] count;
            int[] a;
            int n;
            nhapMang(out a, out n);
            xuLy(a, n, out count);
            timLon(count, a, n);
        }
    }
}
