using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitapchuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            List<string> list = new List<string>();
            string[] lists = s.Split(' ');
            foreach (string y in lists)
            {
                
                list.Add(y);
             }
            foreach (var x in list)
            { Console.WriteLine(x); }
           /* list.Sort();
            foreach (string x in list)
            {

                Console.Write(x + " ");
            }
            Console.WriteLine();
           int max= 1;
            foreach(string y in lists)
            {
                max = y.Length > max ? y.Length : max;
                
            }
            
            foreach(string y in lists)
            {
                if(max==y.Length)
                {
                    Console.WriteLine(y);
                    break;
                }
            }*/




        }
    }
}
