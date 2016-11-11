using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FindAGivenDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNumber = 457;
            int digitToFind = 5;
            //List<int> list = new List<int> { };
            //list.Add(givneNumber);
            //var check = list.ToArray();
            //int[] digit = 12345.ToString().ToCharArray().Select(x => (int)char.GetNumericValue(x)).ToArray(); //convert an into to array

            //int[] digits = Regex.Replace(numberToParse, "[^0-9]", "").Select(x => (int)Char.GetNumericValue(x)).ToArray(); //To take it to the next level and you want to convert an unknown string you can use regex to strip out non numeric characters
            
            int i = Math.Abs(givenNumber);
            while (i != 0)
            {
                i = givenNumber % 10; //a variable to hold modulo

                if (i == digitToFind) { Console.WriteLine("5"); }
                givenNumber /= 10; // a variable which periodically changes with every iteration
                //eventually givenNumber becomes 0 which led to exit the while loop
            }

        }
        public static void func ()
        {

        }
    }
}
