using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cong_0
{
    class Program
    {
        static int kiemTra(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)

                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] == -a[j])
                    {
                        return j;
                    }
                }
            return -1;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (kiemTra(a, n) == -1)
                Console.WriteLine("no");
            else
                Console.WriteLine("yes");

        }
    }
}
