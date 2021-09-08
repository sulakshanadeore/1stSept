using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesLibrary
{
    //declaration of delegate
    public delegate double EmployeeSalaryCalculation(int a, int b, int c);
    public delegate int EmpDisplaySalary(int a);
    public delegate void ShowingAllDetails(int empid);

    public class Employee:EventArgs
    {
        public static event ShowingAllDetails EmployeeJoined;
        public int TotalSal { get; set; }
        public int Others { get; set; }
        public double CalculateSalary(int bs, int da, int ta)
        {
            TotalSal= bs + ta + da;
            return bs + ta + da;

        }
        public int DisplaySalary(int empno)
        {
            int sal = 0;
            if (empno <= 10)
            {
                sal = 20000;
                Others = sal;
            }
            else
            {
                sal = 30000;
                Others = sal;
            }
            return sal;
        }

        public void DisplayDetails(int empno)
        {
            Console.WriteLine("Total Salary=  " + TotalSal);
            Console.WriteLine("Other Allowances= " + Others);
         


        }

        public void AssignDetails(int empno)
        {
            Console.WriteLine("Following r the details of " + empno);
            if (empno != 0)
            {
                EmployeeJoined(empno);//Event---> Delegate
            }
        }


    }
}
