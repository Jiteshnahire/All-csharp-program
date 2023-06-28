using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class EvenNo121To229
    {
        static void Main(string[] args)
        {
            int number = 121;
            Console.WriteLine("Even no 121 to 229");
            do
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
            while (number <= 229);
        }
       
    }
}
