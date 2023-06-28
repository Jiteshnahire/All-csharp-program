using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericList
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
    }
    class Employe
    {
        static void Main(string[] args)
        {
            List<GenericList> empList = new List<GenericList>();

            empList.Add(new GenericList { EmpID = 1, EmpName = "Jitesh", Salary = 50000 });
            empList.Add(new GenericList { EmpID = 2, EmpName = "Arjun", Salary = 60000 });
            empList.Add(new GenericList { EmpID = 3, EmpName = "Ram", Salary = 55000 });
            empList.Add(new GenericList { EmpID = 4, EmpName = "Lakhan", Salary = 65000 });
            empList.Add(new GenericList { EmpID = 5, EmpName = "dev", Salary = 70000 });

            Console.WriteLine("Employee Details:");
            foreach (GenericList employee in empList)
            {
                Console.WriteLine(employee.EmpID);
                Console.WriteLine(employee.EmpName);
                Console.WriteLine(employee.Salary);
                Console.WriteLine();
            }
        }
    }
}
