using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace crazy_I_was_crazy_once
{
    internal class Program
    {
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }

        static void recursiveRange(int min, int max)
        {
            if (min <= max)
            {
                Console.WriteLine(" n = {0} ", min);
                recursiveRange(min + 1, max);
            }
        }

        static string GetRangeString(int min, int max)
        {
            string buffer = "";
            if (min <= max)
            {
                Console.WriteLine("folding");
                buffer += (min + ", " + GetRangeString(min + 1, max) );
                
            }
            Console.WriteLine("unfolding");
            return buffer;
        }

        static int RecursiveMultiply(int value, int mutiple)
        {
            string buffer = "";
            int x = 0;
            if (mutiple > 0 )
            {
                Console.WriteLine("folding");

                x = x + value + RecursiveMultiply(value, mutiple - 1);
                //buffer += (" + " + value  + RecursiveMultiply(value, mutiple-1));

            }
            Console.WriteLine("unfolding");
            return x;
        }

        static int PowerFuncRecursive(int value, int power)
        {
            int x = 1;
            if (power > 0)
            { 
                x = value * PowerFuncRecursive(value, power-1);
                //buffer += (" + " + value  + RecursiveMultiply(value, mutiple-1));
            }
            return x;
        }

        static void Main(string[] args)
        {
            //printNumbers(5);
            //recursiveRange(1,1);
            //Console.WriteLine(RecursiveMultiply(3, 3));
            Console.WriteLine(PowerFuncRecursive(3,3));
            Console.ReadLine();
        }

    }
}
