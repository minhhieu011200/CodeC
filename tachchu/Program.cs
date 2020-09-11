using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tachchu
{
    class Program
    {


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> name = new List<string>();
            List<string> namesort = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                string s = Console.ReadLine();
                name.Add(s);
                string ho = name[i].Substring(0, name[i].IndexOf(' '));
                string ten = name[i].Substring(name[i].LastIndexOf(' ') + 1);
                string tenlot = name[i].Substring(name[i].IndexOf(' ') + 1, name[i].LastIndexOf(' ') - name[i].IndexOf(' '));
                namesort.Add(ten);
            }
            namesort.Sort();
            
            if (n == 2)
            {
                foreach (var a in namesort)
                {
                    foreach (var b in name)
                    {
                        if (a == b.Substring(b.LastIndexOf(' ') + 1))
                        {
                            Console.WriteLine(b);
                        }
                    }
                }
            }
            else
            {
                name.Sort();
                foreach (var a in name)
                {
                    Console.WriteLine(a);
                }
            }







        }
    }
}
