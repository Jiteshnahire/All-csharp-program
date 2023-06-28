using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ReverseArrayWithoutTemp
    {
        static void Main(String[] args)
        {
            int[] array = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine("Original Array");
            PrintArray(array);

            ReverseArray(array);

            Console.WriteLine("Reversed Array");
            PrintArray(array);
        }
        static void ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                arr[start] = arr[start] + arr[end];
                arr[end] = arr[start] - arr[end];
                arr[start] = arr[start] - arr[end];

                start++;
                end--;
            }
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

