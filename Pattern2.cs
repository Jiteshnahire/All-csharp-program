using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pattern2
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                for(int j=i; j <= num; j++)
                {
                    Console.WriteLine("*");
                }
                Console.ReadLine();
            }
        }
    }
}
