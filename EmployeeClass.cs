using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class EmployeeClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        private const double PT = 200;

        public double CalculateGrossSalary()
        {
            double grossSalary = Salary - PT;
            return grossSalary;
        }
        public override string ToString()
        {
            return $"Id={Id} Name={Name} Salary={Salary}";
        }
    }
    class EmployeeClassDemo
    {
        static void Main(string[] args)
        {

            EmployeeClass e = new EmployeeClass { Id = 1, Name = "Jitesh", Salary = 30000 };
            Console.WriteLine(e.ToString());
            e.CalculateGrossSalary();
            Console.WriteLine(e);
        }
    }
}
