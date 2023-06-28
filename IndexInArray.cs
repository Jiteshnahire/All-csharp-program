using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IndexInArray
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 5, 8, 3, 0, 7, 2, 1, 4, 6 };
            int target = 7;

            Console.WriteLine("Original Array");
            PrintArray(array);

            int index = SearchNumber(array, target);

            if (index != -1)
            {
                Console.WriteLine("Number found at index " + index);
            }
            else
            {
                Console.WriteLine("Number not found in array");
            }
        }
        static int SearchNumber(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }

            return -1; 
        }
        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
