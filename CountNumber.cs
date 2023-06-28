using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class CountNumber
    {
        static void Main(string[] args)
        {
            int num = 0, count = 0;
            Console.WriteLine("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            Console.WriteLine("Number of digits is: " + count);
        }
    }
}

