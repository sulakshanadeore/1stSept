using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritancePolyDemo;
namespace CollectionsDemo
{
    class Class1
    {
        static void Main(string[] args)
        {
            //string[] str = new string[5] {"Hi","Hello","Morning","Day","Night" };

            //string[] strcopy = new string[5];
            //Array.Copy(str, strcopy,5);
            //foreach (var item in strcopy)
            //{
            //    Console.WriteLine(item);
            //}
            

            Employee[] emplist = new Employee[5];

         for (int i = 0; i < emplist.Length; i++)
            {
                emplist[i] = new Employee();
                Console.WriteLine("Enter empid");
                emplist[i].Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Deptno");
                emplist[i].Deptno = Convert.ToInt32(Console.ReadLine());


                

            }

            Console.WriteLine("Displaying emplist");
            foreach (var item in emplist)
            {
                Console.WriteLine(item.Empid);
                Console.WriteLine(item.Deptno);
            }
            Employee[] empcopy = new Employee[5];
            Array.Copy(emplist, empcopy, 5);
            foreach (var item in empcopy)
            {
                Console.WriteLine(item.Empid + "\t" + item.Deptno);
            }




            Console.ReadLine();

        }
    }
}
