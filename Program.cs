using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPsLibrary;
namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {

            Products p = new Products();
            Console.WriteLine("Enter Product ID u want to buy");
            p.ProductID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Name");
            p.ProductName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            p.UnitPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Supplier ID");
            p.SupplierID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("U entered the following");

            Console.WriteLine("Searching for your product id " + p.ProductID);//get
            Console.WriteLine("Prodname = " + p.ProductName);
            Console.WriteLine("Price = " + p.UnitPrice);
            Console.WriteLine("Supplier ID=" + p.SupplierID);


            //Console.WriteLine("Enter the way u want to give the details.. 1. default 2.parameterised");
            //int ch = Convert.ToInt32(Console.ReadLine());
            //switch (ch)
            //{
            //    case 1:
            //        Student s = new Student();
            //        ShowAll(s);

            //        CalculatePercentage(s);


            //        break;
            //    case 2:
            //        Console.WriteLine("Enter name ");
            //        string name = Console.ReadLine();
            //        Console.WriteLine("Enter grade");
            //        string g = Console.ReadLine();
            //        Student s1 = new Student(name, g);
            //        ShowAll(s1);
            //        //s1.AcceptMarks();
            //        //s1.CalculateMarks();
            //        //s1.DisplayMarks();

            //        CalculatePercentage(s1);
            //        break;

                
            //}
            



            Console.Read();
        }

        private static void ShowAll(Student s)
        {
            s.AcceptMarks();
            s.CalculateMarks();
            s.DisplayMarks();
        }

        private static void CalculatePercentage(Student s)
        {
            int studentMarks = s.TotalMarks;
            int perc = studentMarks / 3;
            Console.WriteLine(perc);
        }
    }
}
