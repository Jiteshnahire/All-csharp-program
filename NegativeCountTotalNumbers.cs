using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class NegativeCountTotalNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = { -1, -2, -3, -4, 6, 5, 0, 8 };
            int negativeCount = 0;

            Console.WriteLine("Negative elements in array");

            foreach (int num in numbers)
            {
                if(num < 0)
                {
                    Console.WriteLine(num);
                    negativeCount++;
                }
            }
            Console.WriteLine("Total number of negative values: " +negativeCount);
        }
    }
}
