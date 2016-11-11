using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility_soller
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 22;
            
            Solution(n);

        }
        public static int Solution(int n)
        {
            
            int k = 0;
            int j = 1;
            int[] array = new int[n];

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            for (int i =1; i<n; i++)
            {
                k = (i - 1);
                k = array[k] + i;
                if (k < n)
                {
                    array[i] = k;
                }
                else
                {
                    j = i - 1;
                    break;
                }
            }
            return j;
        }
    }
}
