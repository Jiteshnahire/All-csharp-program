using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class EqualityOfTwoArray
    {
        static void Main(string[] args)
        {
            Boolean isEqual = true;

            int[] arr1 = { 12, 22, 32, 42, 52, 62 };
            int[] arr2 = { 52, 22, 62, 12, 42, 32 };

            Array.Sort(arr1);
            Array.Sort(arr2);
            if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        isEqual = false;
                    }
                }
            }
            else
            {
                isEqual= false;
            }
            if (isEqual)
            {
                Console.WriteLine("Both equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}
