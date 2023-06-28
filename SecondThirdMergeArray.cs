using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SecondThirdMergeArray
    {
        static void Main(String[] args)
        {
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 4, 6, 8, 4 };

            int[] mergedArray = MergeArrays(array1, array2);

            Console.WriteLine("Merged Array");
            PrintArray(mergedArray);
        }

        static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] mergedArray = arr1.Concat(arr2).Distinct().ToArray();

            return mergedArray;
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


