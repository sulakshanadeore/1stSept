using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class MyClass
    {
        private  static void M1()
        {
            Console.WriteLine("M1 Called");
        }

        internal static void M2()
        {
            M1();

        }

    }


    class Program
    {
        static int j=100;
        int cnt;

        static void Greet() {

            int i;//declaration
            //Console.WriteLine("Hello");
            Console.WriteLine("enter the value for i");
            //ReadLine--- string
            i = Convert.ToInt32(Console.ReadLine());//storing the value
            Console.WriteLine(i); //print i

            i = i + 50;
            Console.WriteLine(i);
            Console.WriteLine("J here " + Program.j);
            int j = 200;
            Console.WriteLine(j);
            //Console.WriteLine(j);
            //j = j + 10;
            //Console.WriteLine(Program.j);
            //j = j + 20;
            //Console.WriteLine(Program.j);
            //Console.WriteLine(cnt);    


        }

        static void Main(string[] args)
        {
            Greet();
            //M1--- directly not possible
            MyClass.M2();// possible with calss reference depending on access specifier, as of now using public
            
            //Console.WriteLine("World");
            int i = 100;
            Console.WriteLine(i);


            Console.Read();
            

        }
    }
}
