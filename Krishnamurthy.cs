using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Krishnamurthy
    {
        static void Main(String[] args)
        {
            long fact;
            int num, temp, rem, sum = 0, i;

            Console.WriteLine("Enter Number to Check for Krishnamurthy Number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (temp = num; temp > 0; temp = temp / 10)
            {
                fact = 1;

                rem = temp % 10;

                for (i = 1; i <= rem; i++)
                {
                    fact = fact * i;
                }

                sum = (int)(sum + fact);
            }

            if (num == sum)
                Console.WriteLine("given Number is a Krishnamurthy Number.\n", num);
            else
                Console.WriteLine("given Number is not a Krishnamurthy Number.\n", num);
        }
    }
}


