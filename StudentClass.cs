using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class StudentClass
    {
        private int RollNo;
        private string Name;
        private double Subj1, Subj2, Subj3, Total, Percentage;

        public StudentClass(int RollNo, string Name, double Subj1, double Subj2, double Subj3)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.Subj1 = Subj1;
            this.Subj2 = Subj2;
            this.Subj3 = Subj3;
        }
        public void CalculateTotalMarks()
        {
            Total = Subj1 + Subj2+ Subj3;
        }
        public void CalculatePercentage()
        {
            Percentage = (Total / 3.0);
        }
        public override string ToString()
        {
            return $"RollNo={RollNo} Name={Name} Total={Total} Percentage={Percentage}";
        }
    }
    class StudentClasDemo
    {
        static void Main(string[] args)
        {
            StudentClass s = new StudentClass(1, "Jitesh",40, 50, 60);
            s.CalculateTotalMarks();
            s.CalculatePercentage();
            Console.WriteLine(s.ToString());


        }
    }
}
