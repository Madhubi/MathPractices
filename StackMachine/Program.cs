using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            Console.WriteLine("\tThe numbers are:", myStack.Count);
            PrintValues(myStack);
            Console.ReadKey();
        }

        public static void PrintValues(IEnumerable<int> MyCollection)
        {
            foreach(object obj in MyCollection)
            {
                Console.Write(" {0}", obj);
            }
        }



    }
}
