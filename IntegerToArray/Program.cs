using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToArray
{
    class Program
    {
       
        static void Main(string[] args)
        {
           int given =Convert.ToInt32(Console.ReadLine());

            func(given);
        }
        public static void func(int givenInt)
        {
            int _givenInt = Convert.ToInt32(givenInt);
            //int value = 0;

            //int[] arr = new int[_givenInt];
            int[] arr = Enumerable.Range(_givenInt, _givenInt).ToArray();
            /*int sum = 0;
            for (int i = 0; i <= _givenInt; i++)
            {
                arr[i]= value;
                value++;
            }*/
            foreach(int n in arr) { Console.WriteLine(n); }
        }
    }
    
}
