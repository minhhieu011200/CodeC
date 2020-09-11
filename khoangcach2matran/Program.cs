using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoangcach2matran
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
            a = new int[m, n];
            int[,] b = new int[m, n];
            for(int i=0;i<m;i++)
            {
                tokens = Console.ReadLine().Split();
                for(int j=0;j<n;j++)
                {
                    a[i, j] = Convert.ToInt32(tokens[j]);
                }

            }
            for (int i = 0; i < m; i++)
            {
                tokens = Console.ReadLine().Split();
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = Convert.ToInt32(tokens[j]);
                }

            }
            double tong = 0;
            
             
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    tong += Math.Pow(a[i, j] - b[i, j],2);
                    
                }
                
                
               }
            Console.WriteLine(Math.Sqrt(tong));
        }
    }
}
