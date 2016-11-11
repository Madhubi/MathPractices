using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumUpAnArrayOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3,4,5,6,7,8 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            { 
               //i = 0, first index of the array; arr[i] =0, 
                if (arr[i]%2==0)
                {
                    sum += arr[i];
                }
                Console.Write(sum);
            }
        }
    }
}
