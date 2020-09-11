using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuocThi
{
    class Program
    {
        static void Main(string[] args)
        {
            ThiSinh ts = new ThiSinh(121, "fd", 1, 6, 7);
            Console.WriteLine(ts.toString());
        }
    }
}
