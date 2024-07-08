using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinSearchTree<int> tree = new BinSearchTree<int>();
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                //tree.Insert(i);
                tree.Insert(random.Next(99)) ;
            }

            Console.WriteLine(tree.PreOrder());
            //while (true)
            //{
            //    Console.WriteLine("Enter a value from 0 to 99 to check if it exists in the binary tree.\nType '999' to exit");
            //    int userIn = Convert.ToInt32(Console.ReadLine().Trim());
            //    if (userIn == 999)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("does" + userIn + "exist in the tree: " + tree.Contains(userIn));
            //    }
            //}
            Console.WriteLine("The number of nodes in this tree: " + tree.Count());
            Console.WriteLine("The Height of this tree: " + tree.Height());
            //Console.WriteLine(tree.InOrder());
            //Console.WriteLine(tree.PostOrder());

            Console.WriteLine("\n\nPress Enter to Exit.");
            Console.ReadLine();
        }
    }
}
