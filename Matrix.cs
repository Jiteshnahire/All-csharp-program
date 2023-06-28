using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Matrix
    {
        static void Main(string[] args)
        {
            int[,] mat1 = new int[3, 3];
            int[,] mat2 = new int[3, 3];
            int[,] result = new int[3, 3];

            Console.WriteLine("Enter element mat1:");
            for(int i= 0; i < 3; i++)
            {
                for(int j= 0; j < 3; j++)
                {
                    Console.WriteLine("Enter element[{0},{1}]: ", i, j);
                    mat1[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter element mat2:");
            for(int i= 0;i < 3; i++)
            {
                for(int j= 0;j < 3; j++)
                {
                    Console.WriteLine("Enter element[{0},{1}]: ", i, j);
                    mat2[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i= 0; i<3; i++)
            {
                for(int j= 0; j<3; j++)
                {
                    result[i,j]= mat1[i,j]+ mat2[i,j];
                }
            }
            Console.WriteLine("result of mat addition: ");
            for(int i= 0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine(result[i,j] );
                }
            }
        }
    }
}
