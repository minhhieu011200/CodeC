using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demsoluong
{
    class Program
    {
        static void SapXepMang(int[]a,int n)
        {
            int c;
            for(int i=0;i<=n-1;i++)
            {
                for(int j=i+1;j<n;j++)
                {
                    if(a[j]<a[i])
                    {
                        c = a[i];
                        a[i] = a[j];
                        a[j] = c;
                    }
                    
                }
                Console.Write(a[i]+" ");
                
            }
        }
           static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            SapXepMang(a, n);
            Console.WriteLine();
            for(int i=0;i<=n-1;i++)
            {
                int dem = 0;
                for(int j=i;j<n;j++)
                {
                    if (a[i] == a[j])
                    {
                        dem++;
                     }
                   
                }
               
                Console.WriteLine("phan tu {0} xuat hien {1} lan",a[i],dem);
                i+=dem-1;
            }

            
             
           
            






        }
            
    }
}
