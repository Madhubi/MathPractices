using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAstringInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = {"ABCDEFG", "HIJKLMNOP" };
            string findThisString = "JKL";

            int strNumber;
            int strIndex = 0;

            for(strNumber = 0; strNumber <=strArray.Length; strNumber++)
            {
                strIndex = strArray[strNumber].IndexOf(findThisString);
                if (strIndex >= 0) { break; }
            }
            Console.WriteLine("String number: {0}\nString index: {1}",
    strNumber, strIndex);
        }
    }
}
