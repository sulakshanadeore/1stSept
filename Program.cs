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
            Console.WriteLine("Menu");
            Console.WriteLine("-----");

            Console.WriteLine("1.Login \n 2.Forgot Password \n3.Cancel \n 4. Add");
            int userch = Convert.ToInt32(Console.ReadLine());
            User u = new User();
            switch (userch)
            {
                case 1:
                    
                    Console.WriteLine("Eneter ur userid");
                    u.UserID = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    u.Password = Console.ReadLine();

                    bool userstatus = u.ValidateUser();

                    if (userstatus)
                    {

                        Products p = new Products();
                        AcceptData(p);

                        Console.WriteLine("U entered the following");

                        Console.WriteLine("Searching for your product id " + p.ProductID);//get
                        Console.WriteLine("Prodname = " + p.ProductName);
                        Console.WriteLine("Price = " + p.UnitPrice);
                        Console.WriteLine("Supplier ID=" + p.SupplierID);
                    }
                    else
                    {
                        Console.WriteLine("Please check userid/password");
                    }

                    break;

                case 2:
                    Console.WriteLine(u.SecurityQuestion);
                    Console.WriteLine("Enter your answer");
                    u.SecurityAnswer = Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Closing the app");
                    //Console.Read();
                    Environment.Exit(1);
                    break;

                case 4:

                    Maths m = new Maths();
                    Console.WriteLine("Enter first no");
                    m.Fno = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second no");
                    m.Sno = Convert.ToInt32(Console.ReadLine());


                    //Console.WriteLine("Calculating the additon for " + m.Fno + m.Sno); //get is inaccessible for Fno & Sno
                    //m.Answer = 0;//set is inaccessible
                    Console.WriteLine(m.Answer);

                    break;
                default:
                    break;
            }

            

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

        private static void AcceptData(Products p)
        {
            Console.WriteLine("Enter Product ID u want to buy");
            p.ProductID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter Name");
            p.ProductName = Console.ReadLine();

            Console.WriteLine("Enter Price");
            p.UnitPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Supplier ID");
            p.SupplierID = Convert.ToInt32(Console.ReadLine());
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
