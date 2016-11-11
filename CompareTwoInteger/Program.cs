using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTwoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2345;
            int b = 2345;

            int sum1 = 0;
            int sum2 = 0;

            int result = 0;
            while (a > 0 && b>0)
            {
                sum1 += a % 10;
                a /= 10;

                sum2 += b % 10;
                b /= 10;
                if(sum1 == sum2)
                {
                    ++result; // isn't finished yet
                }
            }
        }
    }
}
