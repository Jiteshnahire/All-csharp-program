using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SumOfOdd
    {
        static void Main(string[] args)
        {
            int i, num, sum = 0;
            Console.WriteLine("Enter no");
            num=Convert.ToInt32(Console.ReadLine());

            for(i=1; i<=num; i+=2)
            {
                sum += i;
            }
            Console.WriteLine("Sum of Even no" + num + " " + sum);
        }
    }
}
