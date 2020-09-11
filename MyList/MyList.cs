using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList
    {
        private IntNode pHead = null;
        private IntNode pTail = null;

        internal IntNode PHead { get => pHead; set => pHead = value; }
        internal IntNode PTail { get => pTail; set => pTail = value; }
        public MyList()
        {
            pHead = pTail = null;
        }
        public int Length = 0;
        public int Count()
        {
            return Length;
        }

        public bool IsEmpty()
        {
            if (pHead == null)
                return true;
            else return false;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
            {
                pHead = PTail = newNode;
                Length++;
            }

            else
            {
                newNode.PNext = pHead;
                pHead = newNode;
                Length++;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty())
            {
                pHead = pTail = newNode;
                Length++;
            }
            else
            {
                PTail.PNext = newNode;
                PTail = newNode;
                Length++;
            }
        }
        public void Nhap()
        {
            int x;
            do
            {
                Console.WriteLine("Nhap vao so nguyen(Nhap -1 de ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x < 0) { break; }
                else
                {
                    IntNode pNew = new IntNode(x);
                    AddFirst(pNew);
                }
            }
            while (x != -1);
        }
        public IntNode TimX(IntNode x)
        {
            IntNode p = pHead;
            while (p != null)
            {
                if (p.Data != x.Data)
                {
                    p = p.PNext;
                }
                else return x;
            }
            return null;
        }
        public IntNode getMax()
        {
            Console.Write("So lon nhat:");
            IntNode max = new IntNode();
            max = pHead;
            IntNode pMax = pHead;
            while (pMax != null)
            {
                if (pMax.Data > max.Data)
                {
                    max = pMax;
                }
                else pMax = pMax.PNext;

            }
            return max;
        }
        public IntNode getMin()
        {
            Console.Write("So lon nhat:");
            IntNode min = new IntNode();
            min = pHead;
            IntNode pMin = pHead;
            while (pMin != null)
            {
                if (pMin.Data < min.Data)
                {
                    min = pMin;
                }
                else pMin = pMin.PNext;

            }
            return min;
        }
        public string GetEvenList()
        {
            IntNode p = pHead;
            string i = "";
            while (p != null)
            {
                if (p.Data % 2 == 0)
                {
                    i += p.Data + " ";
                    p = p.PNext;
                }
                else p = p.PNext;

            }
            return i;
        }
        public string GetOddList()
        {
            IntNode p = pHead;
            string i = "";
            while (p != null)
            {
                if (p.Data % 2 != 0)
                {
                    i += p.Data + " ";
                    p = p.PNext;
                }
                else p = p.PNext;

            }
            return i;
        }
        public void Sort()
        {
            for (IntNode i = pHead; i != null; i = i.PNext)
            {
                for (IntNode j = i.PNext; j != null; j = j.PNext)
                {
                    if (i.Data > j.Data)
                    {
                        int temp = i.Data;
                        i.Data = j.Data;
                        j.Data = temp;
                    }
                }
            }
        }
        public IntNode PrevNodeP(IntNode p)
        {
            if (p == PHead)
            {
                return null;
            }
            IntNode pTruoc = PHead;
            while (pTruoc.PNext != p)
            {
                pTruoc = pTruoc.PNext;
            }
            return pTruoc;
        }
        public void RemoveHead()
        {
            if (PHead == PTail)
                PHead = PTail = null;
            else
            {
                IntNode p = PHead;
                p = null;
                PHead = PHead.PNext;
            }
        }
        public void RemoveTail()
        {
            if (PHead == PTail)
                PHead = PTail = null;
            else
            {
                IntNode pTruoc = PrevNodeP(pTail);
                pTail = pTruoc;
                pTail.PNext = null;
            }

        }
        public void RemoveNode(IntNode pDel)
        {
            if (pDel == PHead)
            {
                RemoveHead();
            }
            else if (pDel == pTail)
            {
                RemoveTail();
            }
            else
            {
                IntNode p = pDel;
                IntNode ptruoc = PrevNodeP(pDel);
                ptruoc.PNext = pDel.PNext;
                pDel = null;
            }
        }
        public bool RemoveX(int x)
        {
            IntNode p = new IntNode(x);
            IntNode pn = PHead;
            IntNode px = TimX(p);
            if (px == null)
            { return false; }
            while (pn.Data != x)
            {
                pn = pn.PNext;
            }
            RemoveNode(pn);
            return true;
        }
        public void RemoveAt(int position)
        {
            IntNode px = PHead;
            int k = 0;
            while (k != position)
            {
                k++;
                px = px.PNext;
            }
            RemoveNode(px);
        }
        public void InsertAfterP(IntNode p, IntNode newNode)
        {
            if (p == PHead)
                AddLast(newNode);
            else
            {
                IntNode pSau = p.PNext;
                newNode.PNext = pSau;
                p.PNext = newNode;
            }
        }
        public void InsertBeforeP(IntNode p, IntNode newNode)
        {
            IntNode pTruoc = PrevNodeP(p);
            if (PHead==null)
                AddLast(newNode);
            else
            {
                pTruoc.PNext = newNode;
                newNode.PNext = p;
            }
        }
        public void Xuat()
        {
            IntNode t = pHead;

            while (t != null)
            {
                Console.Write(t.Data + "-->");
                t = t.PNext;
            }
            Console.WriteLine("null");
        }

    }
}
