using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    class Node
    {
        private int data;
        private Node next;

        public Node(int item)
        {
            Data = item;
            Next = null;
        }

        public int Data
        {
            set { this.data = value; }
            get { return this.data; }
        }

        public Node Next
        {
            set { this.next = value; }
            get { return this.next; }
        }

    }

}
