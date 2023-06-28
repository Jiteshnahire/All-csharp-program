using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class CountArrayElements
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                count++;
            }
            Console.WriteLine("Total count" + count);
            Console.ReadLine();
        }
    }
}