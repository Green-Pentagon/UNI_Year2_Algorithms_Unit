using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bah
{
    internal class Program
    {
        static Random rnd = new Random();
        static public void InsertionSort<T>(ref T[] a) where T : IComparable
        {
            for (int i = 1; i < a.Length; i++)
            {
                T value = a[i];
                int j = i;

                for (; j > 0 && value.CompareTo(a[j - 1]) < 1; j--)
                {
                    a[j] = a[j - 1];
                }
                a[j] = value;
            }
        }

        static void swap<T>(ref T x, ref T y) where T : IComparable
        {
            T temp = x;
            x = y;
            y = temp;
        }


        static void BubbleSort<T>(ref T[] numbers) where T : IComparable
        {
            bool swapped = true;
            int upper = numbers.Length - 1;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < upper; i++)
                {
                    if (numbers[i].CompareTo(numbers[i + 1]) > 0 )
                    {
                        swap(ref numbers[i], ref numbers[i + 1]);
                        swapped = true;
                    }   // if
                }  // for
                --upper;

            }  //  while
        }

        static public void SelectionSort<T>(ref T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[smallest]) <0)
                        smallest = j;
                }
                swap(ref a[i], ref a[smallest]);
            }
        }

        static bool IsInOrder<T>(T[] a) where T : IComparable
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i].CompareTo(a[i-1]) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void PrintArray<T>(T[] a) where T : IComparable
        {
            foreach(T element in a)
            {
                Console.Write(element + "|");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int length = 10;
            int[] a = new int[length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 99);
            }

            PrintArray(a);
            Console.WriteLine(IsInOrder(a));
            SelectionSort(ref a);
            Console.WriteLine(IsInOrder(a));
            PrintArray(a);

            //            string[] titles = {"Writing Solid Code",
            //                "Objects First","Programming Gems",
            //                "Head First Java","The C Programming Language",
            //                "Mythical Man Month","The Art of Programming",
            //                "Coding Complete","Design Patterns",
            //                "ZZ"};
            //            string[] authors = { "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            //            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389",
            //"84928334", "4839455", "21331322", "348923948", "43893284",
            //                "9483294", "9823943" };
            //            Book[] library = new Book[10];
            //            // create an array of books
            //            for (int i = 0; i < library.Length; i++)
            //            {
            //                library[i] = new Book(isbns[i], titles[i], authors[i]);
            //            }


            Console.ReadLine();
        }



    }
}
