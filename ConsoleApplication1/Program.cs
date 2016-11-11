using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 800, 11, 50, 300, 2 };
            int temp = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }

            }

            //for (int write = 0; write < arr.Length; write++)
            //{
            //    for (int sort = 0; sort < arr.Length - 1; sort++)
            //    {
            //        if (arr[sort] > arr[sort + 1])
            //        {
            //            temp = arr[sort + 1];
            //            arr[sort + 1] = arr[sort];
            //            arr[sort] = temp;
            //        }
            //    }
            //}
        }
    }
}
