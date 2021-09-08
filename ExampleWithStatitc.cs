using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDelegatesApp
{
    //public void Add(int i, int j)
    //public void Subtract(int i, int j)

    public delegate void Calculations(int i, int j);
    class ExampleWithStatic
    {
              
        public static event Calculations DoCalculation;
        

        static void Main(string[] args)
        {

            ExampleWithStatic.DoCalculation += ExampleWithStatic_DoCalculation;

            DoCalculation(10, 2);

      //ExampleWithStatic.DoCalculation += ExampleWithStatic_DoCalculation;
            //DoCalculation(10, 2);
            Console.Read();

        }

        private static void ExampleWithStatic_DoCalculation(int i, int j)
        {
            ExampleWithStatic s = new ExampleWithStatic();

                Calculations c = new Calculations(s.Add);
                Calculations c1 = new Calculations(s.Subtract);
                Calculations c3=(Calculations)MulticastDelegate.Combine(c, c1);
                c3(i, j);
        }

        //private static void ExampleWithStatic_DoCalculation(int i, int j)
        //{
        //    ExampleWithStatic s = new ExampleWithStatic();
        //    Calculations c = new Calculations(s.Add);
        //    Calculations c1 = new Calculations(s.Subtract);
        //    Calculations c3=(Calculations)MulticastDelegate.Combine(c, c1);
        //    c3(i, j);
        //}

        public void Add(int i, int j)
        {
            Console.WriteLine(i+j);
        }

        public void Subtract(int i,int j)
        {
            Console.WriteLine(i-j);

        }

        public void ShowSquareRoot(int i)
        {

            double ans=Math.Sqrt(i);
            Console.WriteLine(ans);

        }

    }
}
