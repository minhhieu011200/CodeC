using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonhonhat
{
    class Program
    {
        
        static void SapXep(int[] a,int n)
        {
            int c;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (a[j] < a[i])
                    {
                        c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                Console.Write(a[i]+" ");
            }
            
        }
        

    static void Main(string[] args)
        {
           
           
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0;i<n;i++)
            {
            a[i] = Convert.ToInt32(Console.ReadLine());

            }
            SapXep(a, n);
            Console.WriteLine();
            int dem = 1;
            for (int i = 0; i < n-1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    dem++;
                }
            }
            Console.Write(dem+" ");
                
                    
                
              
                                           
            



        }
    }
}
