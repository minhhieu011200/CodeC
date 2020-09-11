
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapxep
{
    class Program
    {
        static void nhapMang(out int[] a, out int n)
        {
            n = Convert.ToInt32(Console.ReadLine());
            a = new int[n];
            for (int i = 0; i < n-1; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void ShellSort(int[] a, int n)
        {
            int pos = 3;
            while (pos > 0)
            {
                for (int i = 0; i < n-1; i++)
                {
                    int j = i;
                    int x = a[i];
                    while (a[j - pos] > x && j>=pos)
                    {
                        {
                            a[j] = a[j-pos];
                            j = j - pos;
                        }
                        a[j] = x;
                    }
                }
                if (pos / 2 != 0)
                    pos = pos / 2;
                else if (pos == 1)
                    pos = 0;
                else pos = 1;
            }
        }
        
    
    static void InsertSort(int[] a, int n)
    {

        int post;
        int x;
        for (int i = 0; i < n - 1; i++)
        {

            x = a[i + 1];
            post = i;
            while ((a[post] > x) && (post > 0))
            {
                a[post + 1] = a[post];
                post--;
                a[post + 1] = x;
            }
            while (post == 0 && a[post] > x)
            {
                a[post + 1] = a[post];
                a[post] = x;

            }
        }
    }
    static void CountingSort(int[] a, int n)
    {
        int max = 0;
        for (int i = 0; i < n; i++)
        {
            max = max > a[i] ? max : a[i];
        }
        int[] count = new int[max + 1];
        for (int i = 0; i < n; i++)
        {
            count[a[i]]++;
        }
        //int m = max;
        for (int i = 0; i < count.Length; i++)
        {
            int m = max;
            int b = count[m - i];

            if (count[m - i] != 0)
            {
                while (count[m - i] <= b && count[m - i] > 0)
                {
                    Console.WriteLine((m - i));
                    count[m - i]--;
                }
                m--;
            }
        }

    }
    static void outPut(int[] a, int n)
    {
        for (int i = 0; i < n-1; i++)
        {
            Console.WriteLine(a[i]);
        }
    }

    static void Main(string[] args)
    {
        int n;
        int[] a = new int[5];
        nhapMang(out a, out n);
        //InsertSort(a, n);
        // outPut(a, n);
        // CountingSort(a, n);
        ShellSort(a, n);
        outPut(a, n);

    }
}
    }

