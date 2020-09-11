using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapxep_nhieucach_
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
        static void HoanVi(ref int a, ref int b)
        {
            if (a < b)
            {
                int tam = a;
                a = b;
                b = tam;
            }
        }
        static int timVTMin(int[] a, int n, int k)
        {
            int vtri = k;
            for (int i = k; i < n; i++)
            {
                if (a[i] < a[vtri])
                    vtri = i;
            }
            return vtri;
        }
        static void SelectionSort(int[] a, int n)
        {
            int vtmin;
            for (int i = 0; i <= n-1; i++)
            {
                vtmin = timVTMin(a, n, i);
                HoanVi(ref a[vtmin], ref a[i]);
            }
        }
        static void Xuat(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
            static void Main(string[] args)
        {
            int n;
            int[] a = new int[3000];
            nhapMang(out a, out n);
            SelectionSort(a, n);
            Xuat(a, n);
        }
    }
}
