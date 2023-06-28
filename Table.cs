using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Table
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Table of no: " + number);
            for(int i=1; i<=10; i++)
            {
                int result = number * i;
                Console.WriteLine(result);
            }
        }
    }
}
