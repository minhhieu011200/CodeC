using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class IntStack
    {
        private int stkMax;
        private int stkTop;
        private string[] stkArray;

        public int StkMax { get => stkMax; set => stkMax = value; }
        public int StkTop { get => stkTop; set => stkTop = value; }
        public string[] StkArray { get => stkArray; set => stkArray = value; }
        public int Count()
        {
            return StkTop + 1;
        }
        public IntStack(int MaxItem = 0)
        {
            stkArray = new string[MaxItem];
            stkTop = -1;
            stkMax = MaxItem;
        }
        public bool IsEmpty()
        {
            if (StkTop == -1)
                return true;
            return false;
        }
        public bool IsFull()
        {
            if (StkTop == StkMax - 1)
                return true;
            return false;
        }
        public string Pop()
        {
            if (IsEmpty())
                return "Not to Pop";
            string outItem = StkArray[StkTop];
            StkTop--;
            return outItem;
        }
        public bool Push(string newItem)
        {
            if (IsFull())
                return false;
            StkTop++;
            StkArray[StkTop] = newItem;
            return true;
        }
        public string Peek()
        {
            if (IsEmpty())
                return "Not to peek";
            return StkArray[StkTop];
        }
        public void Clear()
        {
            for (int i = StkTop + 1; i > 0; i--)
            {
                Pop();
            }
        }
        public bool Contains(string x)
        {
            for (int i = StkTop;i>=0;i--)
                if (stkArray[i] == x)
                    return true;
            return false;
        }
        public void Xuat()
        {
            int post = StkTop;
            for (int i = StkTop + 1; i > 0; i--)
            {
                Console.WriteLine("Phan tu thu {0}:{1}", i, StkArray[post--]);
            }
            Console.WriteLine("Peek: " + Peek());
        }
    }
}
