using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayArrangedNegativeFirst
    {
        static void Main(string[] args)
        {
            int[] array = { 10, -5, 8, -3, 0, -7, 2, 1, -4, 6 };

            Console.WriteLine("Original Array");
            PrintArray(array);

            ArrangeArray(array);

            Console.WriteLine("Arranged Array");
            PrintArray(array);
        }
        static void ArrangeArray(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                while (arr[left] < 0)
                    left++;

                while (arr[right] >= 0)
                    right--;

                if (left < right)
                {
                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;
                }
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