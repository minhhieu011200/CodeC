using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inkytu
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dai hoc tin hoc ngoai ngu tphcm";
            int[] count = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    int index = s[i] - 'a';
                    count[index]++;
                }

            }
            int dem = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    Console.WriteLine("{0}:{1}", (char)(i + 'a'), count[i]);
                    dem++;
                }
            }

            Console.WriteLine(dem);
            int max = 0;
            count[max] = 0;
            for (int i = 0; i < count.Length; i++)
            {

                if (count[i] > count[max])
                {
                    max = i;
                }

            }
            for (int i = 0; i < s.Length; i++)
            {
                if (max == i)
                {
                    Console.WriteLine((char)(i + 97));
                    //break;
                }
            }
        }
    }
}
