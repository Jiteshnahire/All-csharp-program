using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class PositiveNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the value of number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("Number is Positive.");
            }
            else if (num == 0)
            {
                Console.WriteLine("Number is Zero.");
            }
            else
            {
                Console.WriteLine("Number is Negative.");
            }

        }
    }
}
