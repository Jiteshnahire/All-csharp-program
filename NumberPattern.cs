using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NumberPattern
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter no");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i<= num; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    count++;
                    Console.WriteLine(count);
                }
                Console.ReadLine();
            }
        }
    }
}
