using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class VowelOrConsonent
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("character is vowel.");
            }
            else
            {
                Console.WriteLine("character is consonent.");
            }
        }
    }
}
