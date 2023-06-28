using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class ArrayPositiveAndNegeativeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 )
                {
                    arr[i] = arr[i - 1] * arr[i-1];
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
