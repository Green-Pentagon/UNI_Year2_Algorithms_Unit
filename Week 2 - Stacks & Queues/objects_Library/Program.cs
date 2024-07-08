using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace objects_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];  //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville");
            books[1] = new Horror("The Creeping");
            for (int i = 0; i < 2; i++)
            {
                //Console.WriteLine("{0}  {1}", books[i].Author.Name, books[i].Title);
                books[i].PrintSummary();
                
            }
            

            Console.ReadKey();
        }
    }
}

