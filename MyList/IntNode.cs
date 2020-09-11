using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class IntNode
    {
        private int data;
        private IntNode pNext = null;

        public int Data { get => data; set => data = value; }
        internal IntNode PNext { get => pNext; set => pNext = value; }
        public IntNode(int x=0)
        {
            data = x;
            pNext = null;
        }
    }
}
