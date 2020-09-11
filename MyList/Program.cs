using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void TestOutput()
        {
            IntNode node = new IntNode(5);
            //IntNode nodes = new IntNode(6);
            //IntNode nodess = new IntNode(7);
            MyList list = new MyList();
            list.Nhap();
            //list.AddLast(node);
            //list.AddLast(nodes);
            //list.AddLast(nodess);
            //Console.WriteLine(list.PrevNodeP(node).Data);
            //list.RemoveHead();
            //list.Xuat();
            //list.RemoveTail();
            //list.RemoveNode(node);
            int.TryParse(Console.ReadLine(), out int x);
            if (list.RemoveX(x))
            { list.Xuat(); }
            else Console.WriteLine("khong tim thay {0} de xoa",x);
            int.TryParse(Console.ReadLine(), out int pos);
            list.RemoveAt(pos);
            list.Xuat();
            
           
            //Console.WriteLine(list.Count());
            //Console.WriteLine(list.getMax().Data);
            //Console.WriteLine(list.getMin().Data);
            //if (list.TimX(node) == null)
            //    Console.WriteLine("null");
            //else Console.WriteLine("Tim thay: " + list.TimX(node).Data);
        }

        static void Main(string[] args)
        {
            TestOutput();
        }
    }
}
