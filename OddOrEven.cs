using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OddOrEven
    {
        static void Main(String[] args)
        {
            int i;
            Console.WriteLine("Enter number: ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("the number is Even number");
            }
            else
            {
                Console.WriteLine("number is Odd number");
            }
            Console.ReadLine();
        }
    }
}