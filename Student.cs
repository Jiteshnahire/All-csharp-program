using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public override string ToString()
        {
            return $"RollNo={RollNo} Name={Name} Percentage={Percentage}";
        }
    }
    class StudentDemo
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.RollNo = 5;
            s.Name = "Jitesh";
            s.Percentage = 95;
            Console.WriteLine(s);
        }
    }
}
