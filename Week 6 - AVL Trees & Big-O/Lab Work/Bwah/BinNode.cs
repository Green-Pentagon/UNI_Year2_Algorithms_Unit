using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bwah
{
    internal class BinNode<T> where T : IComparable
    {
        private T data;
        public BinNode<T> Left, Right;
        private int balanceFactor = 0;

        public BinNode(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }
        public T Data
        {
            set { data = value; }
            get { return data; }
        }
        public int BalanceFactor
        { get { return balanceFactor; } set {  balanceFactor = value; } }
    }
}
