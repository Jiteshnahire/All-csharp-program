using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class ForLoopAtoZ
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a to z alphabet");

            for(char alpha ='a'; alpha <= 'z'; alpha++)
            {
                Console.WriteLine(alpha + " ");
            }
        }
    }
}
