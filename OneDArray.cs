using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OneDArray
    {
        static void Main(string[] args)
        {
            int[] rainfall = new int[7];
            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine("Days" +i);
                rainfall[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("rainfall in weeks");
            for (int i = 0; i < rainfall.Length; i++)
            {
                Console.WriteLine("rainfall in mm" +i);
            }
        }
    }
}

