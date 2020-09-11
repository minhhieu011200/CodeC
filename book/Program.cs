using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {

            Book p1 = new Book("Bui The Minh Hieu", "minhhieu0112000@gmail.com", "nam", 1000, 2);
            Console.WriteLine(p1.toString());

        }
    }
}
