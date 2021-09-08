using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsDelegatesLibrary;
namespace EventsDelegatesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            //subscribing the delegate
            EmployeeSalaryCalculation del = new EmployeeSalaryCalculation(emp.CalculateSalary);

            //Invoke the delegate to call the method
            double ans=del(1200, 200, 200);
            Console.WriteLine(ans);

            double sal=del.Invoke(1200, 200, 200);
            Console.WriteLine(sal);
            EmpDisplaySalary empsal = new EmpDisplaySalary(emp.DisplaySalary);
            int salary=empsal(20);
            Console.WriteLine(salary);
            Console.WriteLine("--------------------------------------");

            ShowingAllDetails details = new ShowingAllDetails(emp.AssignDetails);
            ShowingAllDetails allDetails = new ShowingAllDetails(emp.DisplayDetails);
            

            ShowingAllDetails showing =(ShowingAllDetails) MulticastDelegate.Combine(details, allDetails);

            showing(10);
            showing.Invoke(10);
            

            Console.Read();

        }
    }
}
