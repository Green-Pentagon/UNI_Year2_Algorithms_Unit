using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwu
{
    internal class Course : IComparable
    {
        string name;
        int credits;

        public Course(string name)
        {
            Name = name;
            credits = 0;
        }

        public Course(string name , int credits)
        {
            Name = name;
            Credits = credits;
        }

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }

        public string Name
        {
            get { return name;}
            set { name = value; }
        }

        public int CompareTo(object val)
        {
            Course temp = (Course)val;
            return credits.CompareTo(temp.Credits);
        }

    }
}
