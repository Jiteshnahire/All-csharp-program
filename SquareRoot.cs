using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First ten terms of the series:");
            for(int i=1; i<=10;  i++)
            {
                int square = i * i;
                Console.WriteLine(i);
            }
        }
    }
}
