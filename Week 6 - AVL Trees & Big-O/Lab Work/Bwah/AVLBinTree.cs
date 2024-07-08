using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Bwah
{
    internal class AVLBinTree<T>: BinSearchTree<T> where T : IComparable
    {
        
        public override void Insert(T item)
        {
            insertItem(item, ref root);
        }

        public override void Remove(T item)
        {
            removeItem(item, ref root);
        }
        //-=-=-=-=-=-=-=-=-=-=-=-=-=

        private void RotateTree(ref BinNode<T> tree)
        {
            //works out the current tree balance factor, rotating the tree if needed.
            tree.BalanceFactor = Height(ref tree.Left) - Height(ref tree.Right);


            if (tree.BalanceFactor < -1)
                rotateLeft(ref tree);
            if (tree.BalanceFactor > 1)
                rotateRight(ref tree);
        }

        private void insertItem(T item, ref BinNode<T> tree)
        {
            //Inserts the item as a leaf
            if (tree == null)
                tree = new BinNode<T>(item);
            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);
            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);

            RotateTree(ref tree);


        }

        private void removeItem(T item, ref BinNode<T> tree)
        {
            //THIS FUNCTION IS NEAR IDENTICAL TO PARENT, HOWEVER CHECKS WEIGHT AND ROTATES UPON FINISHING OF REMOVAL
            if (tree != null) //if tree is not empty (item may exist)
            {
                if (item.CompareTo(tree.Data) < 0)
                {
                    removeItem(item, ref tree.Left);
                }
                else if (item.CompareTo(tree.Data) > 0)
                    removeItem(item, ref tree.Right);
                else
                {
                    if (tree.Left == null && tree.Right != null)

                    {
                        //if there is no left sub-tree, make the right sub-tree the new tree
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
                        removeItem(newRoot, ref tree.Right);
                    }
                    else
                    {
                        tree = null;
                        return; //in the event that the tree has become empty, bail to prevent null exception in RotateTree upon recursion unfolding
                    }
                }
                RotateTree(ref tree);
            }

            

            


        }

        private void rotateLeft(ref BinNode<T> tree)
        {
            //- current root of the tree(old root) is stored
            //- the new root of the tree is going to be the right subtree / leaf of the old root
            //- the left sub-tree of the new root(leftmost tree of old root) becomes the right sub-tree of the old root
            //- the old root moved to become the left sub-tree / leaf of the new root

            if (tree.Right.BalanceFactor > 0)//double rotation
            {
                rotateRight(ref tree.Right);
            }
            
                BinNode<T> oldRoot = tree;
                BinNode<T> newRoot = oldRoot.Right; //conditional: see if this works in the possability that there is something there! (you might need to attach to the end???)
                oldRoot.Right = newRoot.Left;
                newRoot.Left = oldRoot;
                tree = newRoot;
        }

        private void rotateRight(ref BinNode<T> tree)
        {
            //- the current root of the tree becomes the old root
            //- the new root is the tree / leaf of the left side of the old root
            //- the right sub-tree of the new root becomes the left sub-tree of the old root
            //- the old root becomes the right subtree of the new root
            if (tree.Left.BalanceFactor < 0)//double rotation
            {
                rotateLeft(ref tree.Left);
            }
            
                BinNode<T> oldRoot = tree;
                BinNode<T> newRoot = oldRoot.Left;
                oldRoot.Left = newRoot.Right;
                newRoot.Right = oldRoot;
                tree = newRoot;
            
        }

    }
}
