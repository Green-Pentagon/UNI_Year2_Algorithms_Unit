using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bwah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AVLBinTree<int> aVLBinTree = new AVLBinTree<int>();
            //for (int i = 0; i < 10; i++)
            //{
            //    aVLBinTree.Insert(i);
            //    aVLBinTree.Insert(20 - i);
            //}

            //15,25,10,20,23,17
            aVLBinTree.Insert(15);
            //aVLBinTree.Insert(25);
            //aVLBinTree.Insert(10);
            //aVLBinTree.Insert(20);
            //aVLBinTree.Insert(23);
            //aVLBinTree.Insert(17);
            Console.WriteLine("insertion complete");
            Console.WriteLine("Height of AVL Tree: " + aVLBinTree.Height());

            Console.WriteLine(aVLBinTree.InOrder());

            aVLBinTree.Remove(15);

            Console.WriteLine(aVLBinTree.InOrder());
            Console.WriteLine("Height of AVL Tree: " + aVLBinTree.Height());

            Console.ReadLine();
        }
    }
}
