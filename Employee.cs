using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id{ get; set; }

        public String Name { get; set; }

        public double Salary { get; set; }

        
    }
    public class Demo {
        static void Main(String[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Jitesh", Salary = 23000 },
                new Employee { Id = 2, Name = "ram", Salary = 27000 },
                new Employee { Id = 3, Name = "shyam", Salary = 45000 },
                new Employee { Id = 4, Name = "karan", Salary = 19000 }

            };
            foreach (Employee e in emp)
            {
                if(e.Salary>25000)
                {
                    Console.WriteLine(e.Name + " " + e.Salary);                
                }

            }
        }
    }
}
