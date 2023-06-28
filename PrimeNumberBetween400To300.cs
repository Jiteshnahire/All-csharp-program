using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PrimeNumberBetween400To300
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("prime no: ");
            for(int i = 400; i<=300; i++)
            {
                for(int j=400; j<=300; j++)
                {
                    if(i!=j && i%j==0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    Console.WriteLine("\t" + i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
    }
}
