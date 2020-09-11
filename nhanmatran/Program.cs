using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nhanmatran
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, p;
            string[] tokens = Console.ReadLine().Split();
            m = Convert.ToInt32(tokens[0]);
            n = Convert.ToInt32(tokens[1]);
            p = Convert.ToInt32(tokens[2]);
            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                tokens = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(tokens[j]);
                }
            }
            int[,] b = new int[m, p];
            for (int i = 0; i < m; i++)
            {
                tokens = Console.ReadLine().Split();
                for (int j = 0; j < p; j++)
                {
                    b[i, j] = Convert.ToInt32(tokens[j]);
                }
            }
           
            int sum;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < p; j++)
                {
                    sum = 0;
                    for (int k = 0; k < m; k++)
                    {
                        sum += a[i, k] * b[k, j];
                        
                    }
                    Console.Write(sum+ " ");
                }
                Console.WriteLine();
            }
          





        }
    }
}
