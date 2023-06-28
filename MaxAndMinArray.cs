using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MaxAndMinArray
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter array size");
            int s = int.Parse(Console.ReadLine());
            int[] arr = new int[s];

            Console.WriteLine("enter array elements");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];

                }
                else if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Max from array " + max);
            Console.WriteLine("Min from array " + min);
            Console.ReadKey();
        }
    }
}
