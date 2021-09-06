using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //class MyClass
    //{
    //    private  static void M1()
    //    {
    //        Console.WriteLine("M1 Called");
    //    }

    //    internal static void M2()
    //    {
    //        M1();

    //    }

    //}


    class Program
    {
        //static int j=100;
        //int cnt;

        //static void Greet() {

        //    int i;//declaration
        //    //Console.WriteLine("Hello");
        //    Console.WriteLine("enter the value for i");
        //    //ReadLine--- string
        //    i = Convert.ToInt32(Console.ReadLine());//storing the value
        //    Console.WriteLine(i); //print i

        //    i = i + 50;
        //    Console.WriteLine(i);
        //    Console.WriteLine("J here " + Program.j);
        //    int j = 200;
        //    Console.WriteLine(j);
        //    //Console.WriteLine(j);
        //    //j = j + 10;
        //    //Console.WriteLine(Program.j);
        //    //j = j + 20;
        //    //Console.WriteLine(Program.j);
        //    //Console.WriteLine(cnt);    


        //}

        static int cnt=0;
        private static void Print()
        {
            cnt += 1;
            Console.WriteLine("Counter=" + cnt);
        }

        private static void AcceptData()
        {
            Console.WriteLine("Enter Number");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("U entered " + num1);
            Print();
        }

        ///Overloaded the method SwapNos

        /// <summary>
        /// Call by value example
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void SwapNos(int n1,int n2)
        {
            Console.WriteLine("Before Swapping");
            Console.WriteLine("N1= "  + n1);
            Console.WriteLine("N2= " + n2);

            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("N1= " + n1);
            Console.WriteLine("N2= " + n2);

        }

        /// <summary>
        /// Call by reference
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void SwapNos(ref int n1,  ref int n2)
        {
            Console.WriteLine("Before Swapping");
            Console.WriteLine("N1= " + n1);
            Console.WriteLine("N2= " + n2);

            int temp;
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("N1= " + n1);
            Console.WriteLine("N2= " + n2);
        }

        private static double CalculateArea(int radius,out double peri)
        {
            float pi = 3.14f;
            double area = pi * radius * radius;
            //Console.WriteLine(area);
            peri = 2 * pi * radius;
            return area;
            
        }

        private static void CalculateCircleAP(out float peri,int radius,out double area)
        {
            float pi = 3.14f;
             area = pi * radius * radius;
              peri = 2 * pi * radius;
            

        }


        static void Main(string[] args)
        {
            float p;
            double a;
            //    a=CalculateArea(442,out p);
            //Console.WriteLine(a);
            //Console.WriteLine(p);

            CalculateCircleAP(out p, 442,  out a);
            Console.WriteLine(a);
            Console.WriteLine(p);



            //int fno = 100;
            //int sno = 20;
            //SwapNos(fno, sno);//Call by Value
            //SwapNos(ref fno, ref sno);//Addresses of the variables-- Call by reference
            //Console.WriteLine("Fno = " +fno);
            //Console.WriteLine("Sno =" + sno);




            //AcceptData();


            //AcceptData();

            //AcceptData();





            // Greet();
            //M1--- directly not possible
            //MyClass.M2();// possible with calss reference depending on access specifier, as of now using public

            //Console.WriteLine("World");
            //int i = 100;
            //Console.WriteLine(i);


            Console.Read();
            

        }
    }
}
