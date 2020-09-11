using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            IntStack stack = new IntStack(4);
            stack.Push("5");
            stack.Push("4");
            stack.Push("3");
            stack.Push("+");
            stack.Pop();
            //stack.Pop();
            //stack.Clear();
            if (stack.Contains("4"))
            {
                Console.WriteLine("Found X");
            }
            else Console.WriteLine("Not found X");
            //stack.Pop();
            stack.Xuat();
            MyExpression n = new MyExpression("1+18+ 2* 9+   5");
            n.Xuat();
        }
    }
}
