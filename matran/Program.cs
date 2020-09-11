using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matran
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            int m, n;
            string[] tokens = Console.ReadLine().Split();
            m = Convert.ToInt32(tokens[0]);
            n = Convert.ToInt32(tokens[1]);
            int k = Convert.ToInt32(tokens[2]);
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                tokens = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(tokens[j]);
                }
            }
            int tongcot = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j==k-1)
                    tongcot += a[i, k-1];
                }
            }
            Console.WriteLine(tongcot);
            int tonghang = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == k-1)
                        tonghang += a[k-1, j];
                }
            }
            Console.WriteLine(tonghang);
        }
    }
}
