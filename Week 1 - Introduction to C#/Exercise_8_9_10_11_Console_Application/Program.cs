using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_9_10_Console_Application
{
    internal class Program
    {
        static void Ex8FizzBuzz()
        {
            string temp;
            for (int i = 1; i < 101; i++)
            {
                temp = "";
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0)
                    {
                        temp += "Fizz";
                    }
                    if (i % 5 == 0)
                    {
                        temp += "Buzz";
                    }
                }
                else
                {
                    temp = i.ToString();
                }
                Console.WriteLine(temp);
            }
        }
        //------------------------------------------
        static void Ex9UniqueArray()
        {
            //implement an efficient algorithm mto check an array of 100 items for integers in range of 0 - 300 to see if they are all unique
            int[] theArray = new int[100];
            string result = "unique";

            //populating the array
            for (int i = 0; i < 100; i++)
            {
                theArray[i] = i;
            }
            theArray[1] = 0;//duplicate on purpose

            //--------------------------------------
            
            //uncertain if using a second array to store values within would be any more efficient, as it still needs to be traversed to check if any values within match the currently checked value.

            //using a nested for loop to compare every element until either a duplicate is found or the whole array is traversed.
            //linear search, decrementing by 1 each pass to avoid redundancy.
            for (int i = 0;i < theArray.Length; i++)
            {
                for (int j = i+1;j<(theArray.Length); j++)
                {
                    if (theArray[i] == theArray[j])
                    {
                        result = "DUPLICATES";
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
        //------------------------------------------

        static bool Ex10AnagramCheck(string stringA , string stringB)
        {

            if (stringA.Length == stringB.Length)
            {
                //for reference 1st value: TKey, 2nd value: TValue
                //ContainsKey to see if anagram, then if no flags, compare the values of each key type to see if they are equal.
                Dictionary<String, int> stringAcomposition = new Dictionary<string, int>();
                Dictionary<String, int> stringBcomposition = new Dictionary<string, int>();

                //DO STUFF HERE
                //count the number of unique letters for both words: if the lengths of unique letters match, the words are anagrams
                //use either two dictionaries or a 2d dictionary.
            }
            else
            {
                return false;
            }

            return true;//REMOVE ME!!!
        }
        //------------------------------------------

        static bool Ex11StringCheck()
        {
            //Implement an efficient method in C# to determine if a string has all unique characters
            return true; //REMOVE ME!!!
        }
        //------------------------------------------

        static void Main(string[] args)
        {
            //Ex8FizzBuzz();    //DONE
            //Ex9UniqueArray(); //DONE
            Console.WriteLine("is heart an anagram of earth? " + Ex10AnagramCheck("heart","earth"));
            Console.WriteLine("is walls an anagram of earth? " + Ex10AnagramCheck("walls", "earth"));
            //Ex11StringCheck();
        }
    }
}
