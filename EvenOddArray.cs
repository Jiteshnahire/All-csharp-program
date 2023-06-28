using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class EvenOddArray
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


            Console.WriteLine("Even and odd elements in array");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("Even" + arr[i]);
                }

                else
                {
                    Console.WriteLine("Odd" + arr[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
