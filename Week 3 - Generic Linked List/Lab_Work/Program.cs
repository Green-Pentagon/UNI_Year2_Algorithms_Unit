using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> testList = new LinkListGen<int>();
            Random rnd = new Random();
            for (int i = 10; i > 0; i--)
            {
                testList.AppendItem(rnd.Next(1,99));
                Console.WriteLine(testList.DisplayList());
            }

            testList.Sort();
            Console.WriteLine("---LIST SORTED HERE---\n" + testList.DisplayList());


            Console.ReadLine();
        }
    }
}
