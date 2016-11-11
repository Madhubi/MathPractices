using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAspecificTwoDigit
{
    class Program
    {
        public static int[] numberArray ;
        public static int[] toArray(int number, int size)
        {
            numberArray = new int[size];
            for (int i = 1; i < number; i++, number /= 10)
            {
                numberArray[i] = number % 100;
                var check = numberArray[i] == 53;
            }
            Array.Reverse(numberArray);
            return numberArray;
        }

        static void Main(string[] args)
        {

            int givenNumber = 195378538;
            int numberToFind = 53;
            int x;
            //int count = 0; // how to number the result?
            //int numbering = 0;
            var length = givenNumber.ToString().Length;
            toArray(givenNumber, length);
            for(int j =0; j<numberArray.Length; j++)
            {
                if (numberArray[j] == numberToFind)
                {
                    Console.WriteLine(j);
                };
            }
            /*while (givenNumber != 0)
            {
                //x = givenNumber % 100;
                //givenNumber /= 10;
                
                var check = x.Equals(numberToFind);
                //var NumArray = numberArray.Reverse();
                //if (count % 2 == 0) { numbering++; }
                if (check)
                {
                    Console.WriteLine("got the number" + numbering);

                    break;
                }
               // count++;

            }*/

        }
        
        }
   
    }
