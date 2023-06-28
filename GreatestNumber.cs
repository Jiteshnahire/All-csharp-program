using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GreatestNumber
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            Console.WriteLine("Enter the first number.");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second number.");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Third number.");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 < num3)
                {
                    Console.WriteLine("The 1st number is greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 3rd number is greatest among three.");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("The 2nd  number is the greatest among Three.");
            }
            else
            {
                Console.WriteLine("the 3rd number is the greatest among three.");
            }

        }

    }
}

