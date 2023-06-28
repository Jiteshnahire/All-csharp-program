using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[] { 1, 2, 3 };
            array[1] = new int[] { 4, 5 };
            array[2] = new int[] { 6, 7, 8, 9 };

            Console.WriteLine("Display array");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j]);
                }
            }
        }
    }
}
