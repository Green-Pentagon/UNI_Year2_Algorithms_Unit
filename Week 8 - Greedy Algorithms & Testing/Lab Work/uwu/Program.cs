using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uwu
{
    internal class Program
    {
        
        static int MinCourses(List<Course> courses, int target)
        {
            //Sort in descending order (takes by val)
            //Can take more than one of the same course
            //find largest value below or equal to target value
            //increment a counter variable, then repeat until no value was added
            courses.Sort();
            courses.Reverse();
            
            int counter = 0;
            int acc = 0;
            bool cleanPass = false;// in the event that the accumilated sum cannot be equal to target, returns result for closest possible value.

            while (!cleanPass)
            {
                cleanPass = true;
                foreach(Course element in courses)
                {
                    if((acc + element.Credits) <= target)
                    {
                        counter++;
                        acc += element.Credits;
                        cleanPass = false;
                        break;
                    }
                }
            }
            return counter;
        }

        static string Ex3()
        {
            //Solution A1: quick sort in ascending order, access from the back of the array
            //Solution A2: (slower?) quick sort in ascending order, reverse array, access from front of array
            //Solution B: use a boolean array the length of the values array to see if every value has been accessed: with an unsorted array, go through the entire array ad store the largest value which was not yet used, append it, set the boolean at the address equal to true and repeat until there is no false in the array of booleans.

            int[] values = { 4, 2, 6, 3, 8, 3, 6, 3, 5, 1, 1, 0, 3 };
           
            
            string acc = "";

            Array.Sort(values); //quicksort


            for(int i = values.Length-1; i > 0; i--)
            {
                acc += values[i].ToString();
            }
            return acc;
        }

        static string Ex4()
        {
            //identical to Ex3 but with characters sorted in lexicographical order (a-z then 0-9)
            //since dictionaries don't deal with capital letters, assume that all inputs will have lowercase or all uppercase characters?
            //in the event that it does not give all uppercase or lowercase characters, there is a for loop which coverts it, implemented in the algorithm below.
            //also, lexicographical doesn't deal with numbers, so they can either be removed or placed in the beginning or the end of the output in order (decided to include them at the end.)
            char[] values = { '0', '1', 'a', 'b' ,'Z',',','"','.','!','?'};
            string acc = "";

            Array.Sort(values);

            for (int i = values.Length - 1; i > 0; i--) 
            {
                //sets all the characters to lowercase
                //this can also be used to remove any invalid characters (after converting to the same type of case to prevent data loss?), using the range that represents all lowercase alphabet (in ascii its 97 to 122)
                try
                {
                    values[i] = (values[i].ToString().ToLower()).ToCharArray().ElementAt(0);
                }
                catch { }
            }

                for (int i = values.Length - 1; i > 0; i--)
            {

                acc += values[i];
            }
            return acc;
        }

        static void Ex1_and_2()
        {
            List<Course> courses = new List<Course>();
            courses.Add(new Course("Course A", 10));
            courses.Add(new Course("Course B", 15));
            courses.Add(new Course("Course C", 5));
            courses.Add(new Course("Course D", 20));
            courses.Add(new Course("Course E", 1)); //remove me to check for closest value to target.


            Console.WriteLine("The minimum number of courses you would have to attend to meet the target of 50 is: " + MinCourses(courses, 50));
            Console.WriteLine("The minimum number of courses you would have to attend to meet the target of 49 is: " + MinCourses(courses, 49));
        }

        static void Main(string[] args)
        {
            //Ex1_and_2();
            Console.WriteLine(Ex4());
            Console.ReadLine();

        }


    }
}
