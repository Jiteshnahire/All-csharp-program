using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AverageOfArray
    {
        public static int average(int[] array)
        {
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;
            }

            return sum / array.Length;
        }

        public static double average(double[] array)
        {
            double sum = 0;

            foreach (double num in array)
            {
                sum += num;
            }

            return sum / array.Length;
        }

        static void Main()
        {
            int[] intArray = { 10, 20, 30, 40, 50 };
            double[] doubleArray = { 10.5, 20.5, 30.5, 40.5, 50.5 };

            int intAvg = average(intArray);
            double doubleAvg = average(doubleArray);

            Console.WriteLine("Integer Array Average " + intAvg);
            Console.WriteLine("Double Array Average " + doubleAvg);
        }
    }
}



