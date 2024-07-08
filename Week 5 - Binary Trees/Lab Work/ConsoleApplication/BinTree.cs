using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class BinTree<T> where T : IComparable
    {
        //THIS CLASS ONLY PROVIDES THE SKELETON OF A BINARY TREE
        protected BinNode<T> root;
        //-=-=-=-=-=-=-=-=-=-=-=-=-=
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(BinNode<T> node)  //creates a tree with node as the root
        {
            root = node;
        }
        //-=-=-=-=-=-=-=-=-=-=-=-=-=
        public string PreOrder()//N, L , R
        {
            string buffer = "";
            PreOrder(ref root, ref buffer);
            buffer = buffer.Trim(',');
            return "---PRE-ORDER TRAVERSAL IN TREE---\n" + buffer + "\n\n";
        }
        public string InOrder()//L, N , R
        {
            string buffer = "";
            InOrder(ref root, ref buffer);
            buffer = buffer.Trim(',');
            return "---IN-ORDER TRAVERSAL IN TREE---\n" + buffer + "\n\n";
        }
        public string PostOrder()//L, R ,N
        {
            string buffer = "";
            PostOrder(ref root, ref buffer);
            buffer = buffer.Trim(',');
            return "---POST-ORDER TRAVERSAL IN TREE---\n" + buffer + "\n\n";
        }
        //-=-=-=-=-=-=-=-=-=-=-=-=-=
        private void PreOrder(ref BinNode<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += "," + tree.Data;
                PreOrder(ref tree.Left, ref buffer);
                PreOrder(ref tree.Right, ref buffer);
            }

        }

        private void InOrder(ref BinNode<T> tree, ref string buffer)
        {
            if (tree != null)
            {

                InOrder(ref tree.Left, ref buffer);
                buffer += "," + tree.Data;
                InOrder(ref tree.Right, ref buffer);
            }

        }

        private void PostOrder(ref BinNode<T> tree, ref string buffer)
        {
            if (tree != null)
            {

                PostOrder(ref tree.Left, ref buffer);
                PostOrder(ref tree.Right, ref buffer);
                buffer += "," + tree.Data;
            }

        }

    }

}
