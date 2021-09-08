using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsDelegatesLibrary;
namespace EventsDelegatesApp
{
    class EventsDemo
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.CalculateSalary(1000, 200, 200);
            emp.DisplaySalary(10);

            Employee.EmployeeJoined += new ShowingAllDetails(emp.DisplayDetails);
            emp.AssignDetails(10);
            Console.Read();

            
           
        }
    }
}
