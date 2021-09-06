using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPsLibrary;
namespace OOPsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee c = new Employee();//Default constructor of teh class             instance name is c & class name is Class1

            c.AcceptData();

            c.DisplayData();

            Console.WriteLine("-----------------------------");
            Employee p = new Employee();
            p.AcceptData();
            p.DisplayData();
            Console.Read();
        }
    }
}
