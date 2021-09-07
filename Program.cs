using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritancePolyDemo;
namespace DemoApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            //Console.WriteLine("Enter First name");
            //p.Fname = Console.ReadLine();
            //Console.WriteLine("Enter Last name");
            //p.Lname = Console.ReadLine();

            //Console.WriteLine("Enter ur birth date");
            //p.BirthDate = Convert.ToDateTime(Console.ReadLine());

            //Console.WriteLine(p.BirthDate);
            //Console.WriteLine(p.FullName);

            Employee emp = new Employee();
            emp.CalculateSalary(5670.90f, 200, 800);
            Console.WriteLine(emp.Salary);

            Console.WriteLine("------------------------");
            Manager mgr = new Manager();
            mgr.CalculateSalary(5670.90f, 200, 800);
            Console.WriteLine("-------------------------");

            SuperManager smgr = new SuperManager();
            smgr.CalculateSalary(5670.90f, 200, 800);
            Console.WriteLine("---------------------------------");

            Director d = new Director();
            d.CalculateSalary(5670.90f, 200, 800);
            Console.WriteLine("---------------------------------");
            Console.Read();




        }
    }
}
