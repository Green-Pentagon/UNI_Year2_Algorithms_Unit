using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class BinSearchTree<T> : BinTree<T> where T : IComparable
    {  //Only stores unique values, where leftmost item is smaller than root and rightmost is bigger.

        //-=-=-=-=-=-=-=-=-=-=-=-=-=
        public BinSearchTree()
        {
            root = null;
        }
        //-=-=-=-=-=-=-=-=-=-=-=-=-=

        public bool Contains(T item)
        {
            bool exists = false;
            Contains(ref item, ref root, ref exists);
            return exists;

        }

        public int Count()
        {
            int count = 0;
            Count(ref root, ref count);
            return count;
        }

        public int Height() { return Height(ref root); }
        public void Insert(T value) { Insert(value, ref root); }
        public void Remove(T value) { Remove(value, ref root); }

        //-=-=-=-=-=-=-=-=-=-=-=-=-=

        protected int MaxInt(int i1, int i2)
        {
            if (i1 > i2)
            {
                return i1;
            }
            else
            {
                return i2;
            }
        }

        protected int Height(ref BinNode<T> node)
        {
            if (node != null)
            {
                return 1 + MaxInt(Height(ref node.Left), Height(ref node.Right));
            }
            else
            {
                return 0;
            }
        }

        //-=-=-=-=-=-=-=-=-=-=-=-=-=

        private void Contains(ref T item, ref BinNode<T> tree, ref bool exists)
        {
            if (!exists && tree != null)
            {
                switch (item.CompareTo(tree.Data))
                {
                    case 0:
                        exists = true; break;
                    default:
                        Contains(ref item, ref tree.Left, ref exists);
                        Contains(ref item, ref tree.Right, ref exists);
                        break;
                }
            }
        }

        private void Count(ref BinNode<T> tree, ref int count)
        {
            if (tree != null)
            {
                count++;
                Count(ref tree.Left, ref count);
                Count(ref tree.Right, ref count);
            }
        }

        private void Insert(T value, ref BinNode<T> tree)
        {
            if (tree == null)
            {
                tree = new BinNode<T>(value);
            }
            else if (value.CompareTo(tree.Data) < 0)
            {
                Insert(value, ref tree.Left);
            }
            else if (value.CompareTo(tree.Data) > 0)
            {
                Insert(value, ref tree.Right);
            }
        }

        private T LeastItem(BinNode<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return LeastItem(tree.Left);
            }
        }

        private void Remove(T value, ref BinNode<T> tree)
        {
            if (tree != null)
            {
                if (value.CompareTo(tree.Data) > 0)
                //if the value is greater than current tree's root, go into the left subtree
                {
                    Remove(value, ref tree.Left);
                }
                else if (value.CompareTo(tree.Data) < 0)
                //if the value is smaller than the current tree's root, go into the right subtree.
                {
                    Remove(value, ref tree.Right);
                }
                else
                {
                    if (tree.Left == null && tree.Right != null)
                    //if there is no left sub-tree, make the right sub-tree the new tree
                    {
                        tree = tree.Right;
                    }
                    else if (tree.Left != null && tree.Right == null)
                    {
                        //if there is no right sub-tree, make the left sub-tree the new tree
                        tree = tree.Left;
                    }
                    else if (tree.Left != null && tree.Right != null)
                    {
                        //if there are boht left and right sub-trees attached to the root:
                        //make the newRoot the value from the least-most value in the right sub-tree
                        //replace the value that is pending deletion with the new root value
                        //recurr to remove the duplicate new root value out of the tree.
                        T newRoot = LeastItem(tree.Right);
                        tree.Data = newRoot;
                        Remove(newRoot, ref tree.Right);
                    }
                }
            }
        }
    }


}
