using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFirstDigit
{
    class Program
    {
        //find the first digit in a given integer
        static void Main(string[] args)
        {
            int i = Math.Abs(386972);
            while (i >= 10)
                i /= 10;
            int result = i;
        }
    }
}
