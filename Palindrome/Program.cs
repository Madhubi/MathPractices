using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "kayak";
            
            char[] array = word.ToCharArray();
            char[] secondArray = new char[array.Length];
            int i = 0;
            for (int j =array.Length-1; j>=0; j--)
                {
                if (array[i] == array[j]);
                {
                }
                i++;
                }
                
            
        }
    }
}
