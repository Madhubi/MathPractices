using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalIntValue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given an array of ints, total all the values that are even numbers
            int[] givenArray = new int[5] { 1, 0, 3, 4, 5 };

            total(givenArray);
        }

        public static void total(int[] theArray)
        {

            for (int i = 0; i< theArray.Length; i++)
            {
                if(theArray[i]%2 == 0)
                {
                    //int item = givenArray[i] / 2;
                    int item =+ theArray[i];
                }
            }


        }
    }
    
}
