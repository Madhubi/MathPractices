using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var convertedInt = Int32.Parse(input);
            var array = toArray(convertedInt);
            for(int i = 0; i<array.Length; i++)
            {
                array[i] %= 2;
            }
            
        }

        public static int[] toArray(int n)
        {
            if (n == 0) return new int[1] { 0 };
            var digit = new List<Int32>();
            for(; n!=0; n /= 10)
            {
                digit.Add(n % 10);
            }
            var arr = digit.ToArray();
            Array.Reverse(arr);
            return arr;
        }
    }
}
