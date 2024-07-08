using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    class NodeGen<T>
    {
        private T data;
        private NodeGen<T> next;

        public NodeGen(T item)
        {
            Data = item;
            Next = null;
        }
        public NodeGen<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
    }


}
