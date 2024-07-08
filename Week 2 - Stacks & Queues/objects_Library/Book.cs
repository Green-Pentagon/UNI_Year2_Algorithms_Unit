using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objects_Library
{
    class Book : IComparable
    {
        private string title;
        private Person author;
        //----------------------------------------
        public Book(string NewTitle)
        {
            title = NewTitle;
        }

        public Book(string NewTitle, Person NewAuthor) : this(NewTitle)
        {
            author = NewAuthor;
        }
        //----------------------------------------
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public void PrintSummary()
        {
            if (author != null)
            {
                Console.WriteLine("Book Summary\n----\nTitle: " + title + "\nAuthor: " + author.Name + "\nAuthor's Age: " + author.Age + "\n----\n");
            }
        }

        public string[] GetSummary()
            //removes the dependency on the Console.Writeline function.
        {
            string[] summary = { title, author.Name, author.Age.ToString() };
            return summary;
        }

        public int CompareTo(Object obj) //implementation of CompareTo
        {					// 		for IComparable

            Book other = (Book)obj;
            return Title.CompareTo(other.Title);
        }
    }
}
