using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AreaOfTraingle
    {
        static void Main(string[] args)
        {
            int b, h, AreaOfTringle;

            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of h");

            h = Convert.ToInt32(Console.ReadLine());

            AreaOfTringle = (b * h) / 2;
        }
    }
}
