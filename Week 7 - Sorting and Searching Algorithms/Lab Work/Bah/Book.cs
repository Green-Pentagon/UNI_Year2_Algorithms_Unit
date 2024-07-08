using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bah
{
    public class Book : IComparable
    {
        string title;
        string author;
        string isbn;

        public Book(string newAuthor, string newIsbn, string newTitle)
        {
            Title = newTitle;
            Author = newAuthor;
            ISBN = newIsbn;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set
            {
                //checks if the provided isbn fits how an ISBN should be strucured (only characters from 0 to 9)
                //char[] accepted = { '0','1','2','3', '4', '5', '6', '7', '8', '9'};
                //foreach(var item in value)
                //{
                //    if (accepted.Contains(item) == false)
                //    {
                //        break;
                //    }
                //}
                isbn = value;
            }
        }

        //Override on CompareTo to work with the system.
        public int CompareTo(Object item)
        {
            Book other = (Book)item;
            return ISBN.CompareTo(other.ISBN);
        }
    }
}
