using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array5integers
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Array element");

            foreach (int number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}
