using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DivisibleBy5or11
    {
        static void Main(String[] args)
        {
            int num;
            num = 55;
            Console.WriteLine(num);

            if(num%5==0 && num % 11 == 0)
            {
                Console.WriteLine("Divisible by 5 or 11");
            }
            else
            {
                Console.WriteLine("Not divisible by 5 or 11");
            }
            Console.ReadLine();
        }
        
    }
}
