using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class FiveArrayOperations
    {
        static void Main(string[] args)
        {
            int[] number = new int[5];
            Console.WriteLine("Enter 5 integers:");

            for(int i=0; i<number.Length; i++)
            {
                Console.WriteLine(i);
                number[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(number);
            Console.WriteLine("Array sort");
            foreach(int num in number)
            {
                Console.WriteLine(num);
            }

            Array.Reverse(number);
            Console.WriteLine("Reverse Array");
            foreach (int num in number)
            {
                Console.WriteLine(num);
            }

            int[] copyArray = new int[5];
            Array.Copy(number,copyArray,number.Length);

            Console.WriteLine("copied array");
            foreach (int num in copyArray)
            {
                Console.WriteLine(num);
            }

            Array.Clear(number, 0, number.Length);
            Console.WriteLine("cleared array");

            foreach(int num in number)
            {
                Console.WriteLine(num);
            }
        }
    }
}
