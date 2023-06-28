using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee2
    {
        static int count;
        private int id;
        private string name;
        private double salary, hra, ta, pf, gross;
        public Employee2(string name,double salary)
        {

            count++;
            this.id = count;
            this.name=name;
            this.salary=salary;
        }
        public void Calculate()
        {
            hra = salary * 0.40;
            ta = salary * 0.20;
            pf = salary * 0.12;
            gross = (salary + hra + ta) - pf;

        }
        public static void TotalCount()
        {
            Console.WriteLine(count);
        }
        public override string ToString()
        {
            return $"Id ={id} Name={name} Salary={salary} HRA ={hra} TA={ta} PF = {pf} Gross ={gross}";
        }
    }
    public class EmployeDemo
    {

      
        static void Main(string[] args)
        {
            Employee2 e1 = new Employee2("Jitesh", 25000);
            Employee2 e2 = new Employee2("Ram", 45000);
            e1.Calculate();
            Console.WriteLine(e1.ToString());
            Employee2.TotalCount();
        }
    }
}
