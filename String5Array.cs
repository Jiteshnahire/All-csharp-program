using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class String5Array
    {
        static void Main(string[] args)
        {
            string[] studentName = new string[5];

            for(int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine($"Enter student name{i}");
                studentName[i] = Console.ReadLine();
            }
            Array.Sort(studentName);
            Console.WriteLine("Ascending order name list: ");

            foreach(string i in studentName)
            {
                Console.WriteLine(i);
            }

        }
    }
}
