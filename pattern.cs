using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class pattern
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter no");
            int num= int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                for (int j=0; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.ReadLine();
            }
        }
    }
}
